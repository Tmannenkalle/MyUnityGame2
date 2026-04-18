using System.Runtime.CompilerServices;
using UnityEngine;

public class RUUUUUNNN : MonoBehaviour
{
    public bool run;
    public float Mov;

    public Rigidbody2D rb;
    public bool canmove;

    public GameObject player;

    public float time;

    public Collider2D coll;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        run = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canmove)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        else
        {
             rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (player.transform.position.x < transform.position.x && run)
        {
            Mov = 4f;
            time = 2.5f;
            time -= Time.fixedDeltaTime;
            coll.isTrigger = false;
        }
        else if (player.transform.position.x > transform.position.x && run)
        {
            Mov = -4f;
            time = 2.5f;
            time -= Time.fixedDeltaTime;
            coll.isTrigger = false;
        }
        else
        {
            Mov = 0f;
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(Mov, rb.linearVelocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player") && run && time == 0f)
        {
            canmove = false;
            run = false;
        }
    }
}
