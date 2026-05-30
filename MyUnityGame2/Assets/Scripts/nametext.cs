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
        if (move.cutscenenumber == 3)
        {
            if (move.time >= -1f)
            {
                nametxt.text = "Guys, we can talk about this";            
            }
            else if (move.time >= -5f && move.time < -1f)
                nametxt.text = "Just give the sword back and we'll let you go";    
            else
                nametxt.text = "Ok ):";       


            move.speed = 0f;
            move.jumppower = 0f;
            move.mspeed = 0f;
        }
        if (move.cutscenenumber == 4)
        {
            if (move.time >= -1f)
            {
                nametxt.text = "Thank you so much for the help";            
            }
            else if (move.time >= -4f && move.time < -1f)
                nametxt.text = "Here, take the sword";    
            else if (move.time >= -8f && move.time < -4f)
                nametxt.text = "To use it you need to left click";    
            else if (move.time >= -12f && move.time < -8f)
                nametxt.text = "Thats about it! Goodbye";


            move.speed = 0f;
            move.jumppower = 0f;
            move.mspeed = 0f;
        }
        if (move.cutscenenumber == 5)
        {
            if (move.time >= 0 && move.time < 3)
                nametxt.text = "Hello there traveller!";
            else if (move.time >= -4 && move.time < 0)
                nametxt.text = "I am the king of Henritlas, and i need your help!";
            else if (move.time >= -10 && move.time < -4)
                nametxt.text = "As you might know our Kingdom is under attack by the corrupteds and while fighting them i got poisoned";
            else if (move.time >= -17 && move.time < -10)
                nametxt.text = "If you can help the alchemist with the ingredients for the cure, I can get the mage to grant you a special ability";
            else if (move.time >=  -25 && move.time < -17)
                nametxt.text = "What I need is: 1 apple, 2 bat ears, 4 slime juice and 1 fragment of corruption. Got it? If you need to be reminded come back and talk to me!";
            
            move.speed = 0f;
            move.jumppower = 0f;
            move.mspeed = 0f;
        }
        if (move.cutscenenumber == 6 && move.bat_ears < 2 && move.apples < 1 && move.slime_juice < 4 && move.corruption_fragment < 1)
        {
            if (move.time >= -4 && move.time < 3)
                nametxt.text = "What I need is: 1 apple, 2 bat ears, 4 slime juice and 1 fragment of corruption.";
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
