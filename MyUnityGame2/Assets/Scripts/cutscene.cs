using UnityEngine;

public class cutscene : MonoBehaviour
{
    public movement move;
    public int cutscene_number;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            move.cutscenenumber = cutscene_number;
            move.time = 3f;
            move.cutscenetime = 15f;
            Destroy(gameObject);
        }
    }
}
