using UnityEngine;

public class batmove : MonoBehaviour
{
    private float moveHorizontal = 1f;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public float speed = 2.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(moveHorizontal * speed, rb.linearVelocity.y);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Lwall"))
        {
            moveHorizontal = 1f;
        }
        if (collision.gameObject.CompareTag("Rwall"))
        {
            moveHorizontal = -1f;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Lwall"))
        {
            moveHorizontal = 1f;
        }
        if (collision.gameObject.CompareTag("Rwall"))
        {
            moveHorizontal = -1f;
        }
    }
}
