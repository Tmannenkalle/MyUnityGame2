using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class GoinDoor : MonoBehaviour
{
    public bool playerclose;
    public movement move;

    public Vector2 teleport;

    public GameObject play;

    public KeyCode F = KeyCode.F;

    public float del;

    void Update()
    {
        if (playerclose && Input.GetKeyDown(F))
        {
            play.transform.position = teleport / del;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerclose = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            playerclose = false;
        }
    }
}
