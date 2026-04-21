using UnityEngine;
using UnityEngine.Rendering.Universal;

public class movement : MonoBehaviour
{
    public float speed = 5f;
    public float mspeed = 5f;
    public float jumppower = 8.5f;
    public bool is_jumping;
    private float moveHorizontal;
    private Rigidbody2D rb;
    public KeyCode up = KeyCode.Space;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode dash = KeyCode.LeftShift;
    public Light2D globalLight;
    public float targetIntensity = 0.3f;
    public float fadeSpeed = 1f;
    private float dashtime = 0.2f;
    private float maxdashtime = 0.2f;
    public float timer = 0f;
    private bool isdashing;
    public int jumps = 1;
    public int maxjumps = 1;
    public int health = 10;
    public int maxhealth = 10;
    public int losthealth = 0;
    public int stamina = 100;
    public int maxstamina = 100;
    public float bounceForce = 20f;
    public float minibounceForce = 5f;
    public int gtxt = 0;
    public float gtxtime = 15f;
    public bool hermesboots;
    public Light2D gl;
    public float dftime = 0.2f;
    private bool df = false;
    public attack att;

    public SpriteRenderer sr;
    public int coins = 0;

    [SerializeField] private Animator an;
    bool iswalking;

    public int coinsoptimization = 0;
    public float respawnx;
    public float respawny;
    public bool haveSword;
    public int cutscene;
    public float cutscenetime;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        an = GetComponent<Animator>();
        att = FindObjectOfType<attack>();
        if (gl == null)
            gl = GetComponent<Light2D>();
    }
    void Update()
    {        
        if (stamina < maxstamina && timer > 0.075f)
        {
            stamina += 1;
            timer = 0f;
        }
        moveHorizontal = 0f;
        if (Input.GetKey(left))
        {
            moveHorizontal = -1f;
            iswalking = true;
            sr.flipX = true;
        } 
        else if (Input.GetKey(right))
        {
            moveHorizontal = 1f;
            iswalking = true;
            sr.flipX = false;
        }
        else
        {
            iswalking = false;
        }
        if (Input.GetKeyDown(up))
        {
            
            if (jumps > 0)
            {
                rb.AddForce(new Vector2(0f, jumppower), ForceMode2D.Impulse);
                jumps -= 1;
                is_jumping = true;
            }
            
            
              
        }
        if (Input.GetKeyDown(dash))
        {
            if (stamina >= 50f)
            {
                isdashing = true;
                dashtime = maxdashtime;
                stamina -= 50;
            }
        }
        if (health <= 0)
        {
            health = 10;
            losthealth = 0;
            transform.localPosition = new Vector3(respawnx,respawny,0f);
        }
        if (iswalking)
        {
            an.SetBool("IsWalking", true);
        }
        else if(iswalking == false)
        {
            an.SetBool("IsWalking", false);
        }
        if (is_jumping)
        {
            an.SetBool("IsJumping", true);
        }
        else
        {
            an.SetBool("IsJumping", false);
        }
        if (att.isatack)
        {
            Debug.Log(att);
            an.SetBool("Isatacking", true);
        }
        else
        {
            an.SetBool("Isatacking", false);
        }
    }
    void FixedUpdate()
    {
        if (isdashing)
        {
            speed = mspeed * 5;
            dashtime -= Time.fixedDeltaTime;
            rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);
            if (dashtime <= 0f)
            {
                isdashing = false;
            }
        }
        else
        {
            timer += Time.fixedDeltaTime;
            speed = mspeed;
            rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);

        }


        if (gtxt > 0)
            cutscenetime -= Time.fixedDeltaTime;
        if (cutscenetime <= 0)
        {
            speed = 5f;
            mspeed = 5f;
            jumppower = 8.5f;
        }
        if (cutscenetime <= -1)
        {
            gtxt = 0;
            mspeed *= 1.2f;
            jumppower *= 1.2f;
        }
        if (df)
        {
            gl.color = Color.red;
            dftime -= Time.fixedDeltaTime;
            if (dftime <= 0f)
            {
               gl.color = Color.white; 
               dftime = 0.2f;
               df = false;
            }
        }
    }
    //The npc interaction stuff is at the bottom of the collision stuff
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            jumps = maxjumps;
            is_jumping = false;            
        }
        if (collision.gameObject.CompareTag("Twall"))
        {
            jumps = maxjumps;
            is_jumping = false;            
        }
        if (collision.gameObject.CompareTag("Rwall"))
        {
            jumps = maxjumps;
            is_jumping = false;            
        }
        if (collision.gameObject.CompareTag("Lwall"))
        {
            jumps = maxjumps;
            is_jumping = false;            
        }
        if (collision.gameObject.CompareTag("boing"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, bounceForce);
        }
        if (collision.gameObject.CompareTag("miniboing"))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, minibounceForce);
        }
        if (collision.gameObject.CompareTag("god_text"))
        {
            jumps = 0;
            gtxt = 2;
            speed = 0f;
            mspeed = 0f;
            mspeed *= 1.2f;
            jumppower *= 1.2f;
            hermesboots = true;
            cutscenetime = 15f;
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            df = true;
            health -= 1;
            losthealth += 1;
        }
        if (collision.gameObject.CompareTag("coin"))
        {
            coins += 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("cutscene"))
        {
            cutscene += 1;
        }

    }
}
