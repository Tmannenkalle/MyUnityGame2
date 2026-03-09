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
        if (move.gtxtime < 0f)
            Actualnametext.text = "";
    }
}
