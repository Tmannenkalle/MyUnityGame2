using System.Diagnostics;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Pla;

    public Rigidbody2D rbo;

    public bool isclose;

    public float move;

    public Rigidbody2D Plarb;

    public float sped = 1.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbo = GetComponent<Rigidbody2D>();
        Plarb = Pla.GetComponent<Rigidbody2D>();
    }   

    // Update is called once per frame
    void Update()
    {
        if (Pla.transform.position.x < transform.position.x && isclose)
        {
            move = -1f;
        }
        else if (Pla.transform.position.x > transform.position.x && isclose)
        {
            move = 1f;
        }
        else if (Pla.transform.position == transform.position || isclose == false)
        {
            move = 0;
        }
    }
    void FixedUpdate()
    {
         if (isclose)
        {
            rbo.linearVelocity = new Vector3(move * sped, rbo.linearVelocity.y);
        }
    }
}

