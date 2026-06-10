using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using NUnit.Framework;
using TMPro;
using Unity.VisualScripting;
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

    public GameObject teleportpath;

    public float timer;

    void Start()
    {
        wait.SetActive(false);
    }

    void Update()
    {
        if (playerclose && Input.GetKeyDown(F))
        {
            loading = true;
            timeforwait = 2.5f;
            timer = 3f;
            Time.timeScale = 0f;
        }
         if (loading)
        {
            timeforwait -= Time.unscaledDeltaTime;
            if (timeforwait <= 1f)
            {
                play.transform.position = teleportpath.transform.position;
            }
            if(timeforwait <= 0f)
            {
                wait.SetActive(false);
                loading = false;
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
