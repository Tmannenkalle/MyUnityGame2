using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Pla;

    public Rigidbody2D rbo;

    public float move;

    public bool isclose;

    public Rigidbody2D Plarb;

    public float sped = 1.5f;

    public float followRadius = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbo = GetComponent<Rigidbody2D>();
    }   

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, Pla.transform.position);
        isclose = distance < followRadius;
        if (isclose)
        {
            if (Pla.transform.position.x < transform.position.x)
        {
            move = -1f;
        }
            else if (Pla.transform.position.x > transform.position.x)
        {
            move = 1f;
        }
            else
        {
            move = 0;
        }
    }
    }
    void FixedUpdate()
    {
         if (isclose)
        {
            rbo.linearVelocity = new Vector2(move * sped, rbo.linearVelocity.y);
        }
        else
        {
            rbo.linearVelocity = new Vector2(0, rbo.linearVelocity.y);
        }
    }
}

