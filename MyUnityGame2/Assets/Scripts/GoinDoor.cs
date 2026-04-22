using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class GoinDoor : MonoBehaviour
{
    public Vector3 teleport;

    public bool playerclose;

    public KeyCode F = KeyCode.F;

    public GameObject play;
    void Start()
    {
        
    }
    void Update()
    {
        if (playerclose && Input.GetKeyDown(F))
        {
            play.transform.position = teleport;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Detector"))
        {
            playerclose = true;
        }
    }
}
