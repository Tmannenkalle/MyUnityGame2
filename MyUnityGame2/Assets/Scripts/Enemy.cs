using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject Pla;
    public Vector3 distance;

    public Rigidbody2D rbo;

    public bool isclose;

    public float move;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rbo = GetComponent<Rigidbody2D>();
        distance = new Vector3(10f, 5f, 0f);
    }

    // Update is called once per frame
    //void Update()
    //{
       //if (rbo.linearVelocity.x < Pla.linearVelocity + distance)
       //{
            //isclose = true;
       //}
       //else
        //{
            //isclose = false;
        //}
        //if (Pla.linearVelocity.x > rbo.linearVelocity.x)
        //{
            //move = -1f;
        //}
        //else if (Pla.transform.position.x < rbo.linearVelocity.x)
        //{
            //move = 1f;
        //}
        //else
        //{
            //move = 0;
        //}
        //if (rbo.linearVelocity != Pla.linearVelocity && isclose)
        //{
            //rbo.linearVelocity = new Vector3(rbo.linearVelocity.x + 1, rbo.linearVelocity.y);
        //}
    //}
}
