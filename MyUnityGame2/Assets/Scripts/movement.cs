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

    public SpriteRenderer sr;

    [SerializeField] private Animator an;

    bool iswalking;

    public 


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        an = GetComponent<Animator>();
    }
    void Update()
    {        
        if (stamina < maxstamina && timer > 0.15f)
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
        if (hermesboots)
        {
            
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
            gtxtime -= Time.fixedDeltaTime;
        if (gtxtime <= 0)
        {
            speed = 5f;
            mspeed = 5f;
            jumppower = 8.5f;
        }
        if (gtxtime <= -1)
        {
            gtxt = 0;
            gtxtime = 15f;
            mspeed *= 1.2f;
            jumppower *= 1.2f;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
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
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            health -= 1;
            losthealth += 1;
        }
    }
}
