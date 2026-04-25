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

    public GameObject wait;

    public float timeforwait;

    void Start()
    {
        wait.SetActive(false);
    }

    void Update()
    {
        if (playerclose && Input.GetKeyDown(F))
        {
            timeforwait = 2.5f;
            wait.SetActive(true);
            play.transform.position = teleport / del;
        }
        wait.transform.position = play.transform.position;
        if (timeforwait >= 0f)
        {
            wait.SetActive(false);
        }
    }
    void FixedUpdate()
    {
        timeforwait -= Time.fixedDeltaTime;
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
