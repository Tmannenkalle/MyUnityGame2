using UnityEngine;

public class slimehealth : MonoBehaviour
{
    public float hpShrink;
    public float hpMove;
    public movement move;
    void Update()
    {
        transform.localScale = new Vector3(hpShrink * move.slimehealth, 0.6f, 1f);
        transform.localPosition = new Vector3(hpMove * move.slimelosthealth, 0f, 0f);
    }
}
