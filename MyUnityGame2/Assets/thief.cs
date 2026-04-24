using UnityEngine;
using UnityEngine.UIElements;

public class MoveRight : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public movement move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (move.cutscenenumber == 2 && move.time <= -8f)
        {
            if (move.time >= -11.5f && move.time <= -8f)
                rb.linearVelocity = new Vector2(speed, rb.linearVelocity.y);
            else
            {
                rb.linearVelocity = new Vector2(0f, rb.linearVelocity.y);
                transform.localPosition = new Vector3(181f, -4.786f, 0f);
            }
        }
    }
}