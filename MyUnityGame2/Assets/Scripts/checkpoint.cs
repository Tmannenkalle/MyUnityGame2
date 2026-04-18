using UnityEngine;

public class checkpoint : MonoBehaviour
{
    public float checkpointposx;
    public float checkpointposy;
    public movement move;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            move.respawnx = checkpointposx;
            move.respawny = checkpointposy;
        }
    }
}
