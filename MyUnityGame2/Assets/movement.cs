using UnityEngine;

public class movement : MonoBehaviour
{
    public float speed = 3f;
    public float mspeed = 3f;
    public float jumppower = 1f;
    private float moveHorizontal;
    private Rigidbody2D rb;
    public KeyCode up = KeyCode.Space;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public KeyCode dash = KeyCode.LeftShift;
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
    private bool boots = false;
    bool iswalking;
    [SerializeField] private Sprite jenspåtur1;
    [SerializeField] private Sprite jenspåtur2;

    [SerializeField] private Sprite jensikkepåtur;

    private SpriteRenderer sr;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();

    }
    void Update()
    {
        if (boots)
        {
            speed = 4;
        }
        
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
        if (Input.GetKey(right))
        {
            moveHorizontal = 1f;
            iswalking = true;
            sr.flipX = false;
        } 
        if (Input.GetKeyDown(up))
        {
            if (jumps > 0)
            {
                if (boots)
                    jumppower = 1.25f;
                else
                    jumppower = 1f;
                rb.AddForce(new Vector2(0f, jumppower), ForceMode2D.Impulse);
                jumps -= 1;
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
            sr.sprite = jenspåtur1;
        }
        else
        {
            sr.sprite = jensikkepåtur;
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
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            jumps = maxjumps;
            
        }
        if (collision.gameObject.CompareTag("Untagged"))
        {
            jumps = maxjumps;
        }
        if (collision.gameObject.CompareTag("boing"))
        {
            jumppower = 15f;
            rb.AddForce(new Vector2(0f, jumppower), ForceMode2D.Impulse);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("slime"))
        {
            health -= 1;
            losthealth += 1;
        }
        else if (collision.gameObject.CompareTag("Bat"))
        {
            health -= 1;
            losthealth += 1;
        }
    }
}
