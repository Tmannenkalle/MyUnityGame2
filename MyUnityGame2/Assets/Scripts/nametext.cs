using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class nametext : MonoBehaviour
{
    public movement move;
    public TMP_Text nametxt;
    void Update()
    {
        if (move.gtxt > 0)
        {
            nametxt.text = "Hello there traveller!";
            if (move.time <= 0f)
            {
                nametxt.text = "It gets lonely up here sometimes, so thanks for visiting!\nAs a reward you get hermes boots which make you 20% faster and give you 20% more jumppower!";
            }
        }
        if (move.cutscenetime <= 0f && move.gtxt == 0)
        {
            nametxt.text = "";
            move.cutscenenumber = 0;
            if (move.hermesboots)
            {
                move.jumppower = 10.2f;
                move.mspeed = 6f;
            }
            else
            {
                move.mspeed = 5f;
                move.jumppower = 8.5f;
            }
        }
        if (move.cutscenenumber == 1)
        {
            if (move.time <= 0f && move.time > -6f)
            {
                nametxt.text = "I see you don't have a weapon with you? \nI had one, but it got stolen.";            
            }
            else if (move.time <= -6f)
            {
                nametxt.text = "If you can find the thief, I can give it to you.\nI think he's in the town somewhere";
            } 
            else
                nametxt.text = "Hello there traveller!";
            move.speed = 0f;
            move.jumppower = 0f;
            move.mspeed = 0f;
        }
        if (move.cutscenenumber == 2)
        {
            if (move.time >= -3f)
            {
                nametxt.text = "Hi man... Why are there wanted posters all over town \nwith your face on them";            
            }
            else if (move.time >= -7f && move.time < -3f)
                nametxt.text = "uhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh";    
            else
                nametxt.text = "YOU'LL NEVER CATCH ME ALIVEEEEEEEEEEEE!!!!!!!!!!!";       


            move.speed = 0f;
            move.jumppower = 0f;
            move.mspeed = 0f;
        }

    }

    void FixedUpdate()
    {
        if (move.gtxt > 0)
            move.time -= Time.fixedDeltaTime;
        if (move.cutscenenumber > 0)
        {
            move.cutscenetime -= Time.fixedDeltaTime;
            move.time -= Time.fixedDeltaTime;
        }

    }
}
