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

    public bool loading;

    void Start()
    {
        wait.SetActive(false);
    }

    void Update()
    {
        if (playerclose && Input.GetKeyDown(F))
        {
            wait.SetActive(true);
            loading = true;
            Time.timeScale = 0f;
            timeforwait = 2.5f;
            play.transform.position = teleport / del;
        }
         if (loading)
        {
            timeforwait -= Time.unscaledDeltaTime;
            if (timeforwait <= 0f)
            {
                loading = false;
                wait.SetActive(false);
                Time.timeScale = 1f;
            }
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
