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

    }
}
