using UnityEngine;

public class textbox : MonoBehaviour
{
    public movement move;
    void Update()
    {
        if (move.gtxt > 0)
        {
            transform.localScale = new Vector3(10f, 2.5f, 1f);
        }
        if (move.cutscenetime <= 0f)
            transform.localScale = new Vector3(0f, 2.5f, 1f);
        if (move.cutscenenumber > 0)
            transform.localScale = new Vector3(10f, 2.5f, 1f);

    }
}
