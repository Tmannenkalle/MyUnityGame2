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
    public float timer = 4.5f;
    public float maxtimer = 4.5f;
    private bool isdashing;
    public int jumps = 1;
    public int maxjumps = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        
        moveHorizontal = 0f;
        if (Input.GetKey(left))
        {
           moveHorizontal = -1f;
           transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        } 
        if (Input.GetKey(right))
        {
            moveHorizontal = 1f;
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        } 
        if (Input.GetKeyDown(up))
        {
            if (jumps > 0)
            {
                rb.AddForce(new Vector2(0f, jumppower), ForceMode2D.Impulse);
                jumps -= 1;
            }
              
        }
        if (Input.GetKeyDown(dash))
        {
            if (timer <= 0f)
            {
                isdashing = true;
                dashtime = maxdashtime;
                timer = maxtimer;
            }
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
                timer = maxtimer;
                isdashing = false;
            }


        }

        else
        {
            timer -= Time.fixedDeltaTime;
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
    }
}
