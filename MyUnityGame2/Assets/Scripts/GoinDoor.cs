using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class GoinDoor : MonoBehaviour
{
    public int Doorkey;
    public movement move;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            move.doornumb = Doorkey;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            move.doornumb = 0;
        }
    }
}
