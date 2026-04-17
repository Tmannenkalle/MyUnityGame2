using System.Runtime.CompilerServices;
using UnityEngine;

public class RUUUUUNNN : MonoBehaviour
{
    public bool run;
    public float Mov;

    public Rigidbody2D rb;
    public bool canmove;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        run = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (run)
        {
            Mov = 2;
        }
        else
        {
            Mov = 0;
        }
        if (canmove)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
        else
        {
             rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
    }
    void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(Mov, rb.linearVelocity.y);
    }
}
