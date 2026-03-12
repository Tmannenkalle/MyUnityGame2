using UnityEngine;

public class batmovevert : MonoBehaviour
{
    private float moveVertical = 1f;
    private Rigidbody2D rb;
    public SpriteRenderer sr;
    public float speed = 1.5f;
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
        rb.linearVelocity = new Vector2(rb.linearVelocity.x, moveVertical * speed);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            moveVertical = 1f;
        }
        if (collision.gameObject.CompareTag("Twall"))
        {
            moveVertical = -1f;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            moveVertical = 1f;
        }
        if (collision.gameObject.CompareTag("Twall"))
        {
            moveVertical = -1f;
        }
    }
}
