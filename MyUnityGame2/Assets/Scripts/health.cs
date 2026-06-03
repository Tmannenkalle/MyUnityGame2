using UnityEngine;

public class health : MonoBehaviour
{
    public float hpShrink;
    public float hpMove;
    public movement move;
    void Update()
    {
        transform.localScale = new Vector3(hpShrink * move.health, 0.6f, 1f);
        transform.localPosition = new Vector3(hpMove * move.losthealth, 0f, 0f);
    }
}
