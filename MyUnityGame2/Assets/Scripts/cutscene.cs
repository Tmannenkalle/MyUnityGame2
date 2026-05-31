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
                transform.localPosition = new Vector3(-4f, 0f, 0f);
                move.blocks += 1;
            } 
            if (move.cutscenenumber == 3)
            {
                move.cutscenetime = 15f;
                transform.localPosition = new Vector3(-1f, 0f, 0f);
                move.blocks += 1;

            }
            if (move.cutscenenumber == 4)
            {
                move.cutscenetime = 15f;
                transform.localPosition = new Vector3(390f, -20f, 0f);    
            }
            if (move.cutscenenumber == 5)
            {
                move.cutscenetime = 28f;
                transform.localPosition = new Vector3(390f, -20f, 0f);    
            }
            if (move.cutscenenumber == 6 && move.bat_ears < 2 && move.apples < 1 && move.slime_juice < 4 && move.corruption_fragment < 1)
            {
                move.cutscenetime = 7f;
                transform.localPosition = new Vector3(390.5f, -20f, 0f); 
                cutscene_number -= 1;   
            }
            cutscene_number += 1;
        }
    }
}
