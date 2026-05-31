using UnityEngine;
using TMPro;
public class objective_text : MonoBehaviour
{
    public movement move;
    public TMP_Text objectivetxt;
    public float text_time = 4f;
    public bool Text_On_Screen;
    void Update()
    {
        if (move.cutscenenumber == 1 && move.time <= -11.5f)
        {
            Text_On_Screen = true;
            objectivetxt.text = "Objective: Find the thief";
        }
        else if (move.cutscenenumber == 2 && move.time <= -11.5f)
        {
            Text_On_Screen = true;
            objectivetxt.text = "Objective: CHASE HIM DOWN!";
        }
        else if (move.cutscenenumber == 4 && move.time <= -11.5f)
        {
            Text_On_Screen = true;
            objectivetxt.text = "Objective: Keep exploring";
        }
        else if (move.cutscenenumber == 5 && move.time <= -24.5f)
        {
            Text_On_Screen = true;
            objectivetxt.text = "Objective: Find the ingredients";
        }
        if (text_time <= 0)
        {
            Text_On_Screen = false;
            text_time = 4f;
        }
    }   

    void FixedUpdate()
    {
        if (Text_On_Screen == true)
        {
            text_time -= Time.fixedDeltaTime;
        }
        else if (Text_On_Screen == false)
        {
            objectivetxt.text = "";
        }
    } 
}
