using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class nametext : MonoBehaviour
{
    public movement move;
    public TMP_Text nametxt;
    public float time = 3f;
    void Update()
    {
        if (move.gtxt > 0)
        {
            nametxt.text = "Hello there traveller!";
            if (time <= 0f)
            {
                nametxt.text = "It gets lonely up here sometimes, so thanks for visiting!\nAs a reward you get hermes boots which make you 20% faster and give you 20% more jumppower!";
            }
        }
        if (move.cutscenetime < 0f)
            nametxt.text = "";
    }

    void FixedUpdate()
    {
        if (move.gtxt > 0)
            time -= Time.fixedDeltaTime;
    }
}
