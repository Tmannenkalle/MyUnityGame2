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
            if (move.cutscenenumber == 1)
            {
                move.cutscenetime = 15f;
                transform.localPosition = new Vector3(-140.8f, 4.6333f, 0f);
            }
            if (move.cutscenenumber == 2)
            {
                move.cutscenetime = 15f;
                transform.localPosition = new Vector3(-140.8f, -4.6333f, 0f);
            } 
            cutscene_number += 1;
        }
    }
}
