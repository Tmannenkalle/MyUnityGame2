using UnityEngine;
using TMPro;

public class actualnametext : MonoBehaviour
{
    public movement move;
    public TMP_Text Actualnametext;

    void Update()
    {
        if (move.gtxt > 0)
        {
            Actualnametext.text = "God (In this universe)";
        }
        if (move.cutscenetime <= 0f)
            Actualnametext.text = "";

        if (move.cutscenenumber == 1)
        {
            Actualnametext.text = "Old man";
        }
        if (move.cutscenenumber == 2)
        {
            Actualnametext.text = "Player";
        }
        if (move.cutscenenumber == 2 && move.time <= -3f)
        {
            Actualnametext.text = "Mysterious man";
        }
        if (move.cutscenenumber == 3)
        {
            Actualnametext.text = "Thief";
        }
        if (move.cutscenenumber == 3 && move.time <= -1f)
        {
            Actualnametext.text = "Old man";
        }
        if (move.cutscenenumber == 3 && move.time <= -5f)
        {
            Actualnametext.text = "Thief";
        }
        if (move.cutscenenumber == 4)
        {
            Actualnametext.text = "Old man";
            move.haveSword = true;
        }

    }
}
