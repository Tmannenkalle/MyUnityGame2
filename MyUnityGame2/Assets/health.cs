using UnityEngine;

public class health : MonoBehaviour
{
    public movement move;
    void Update()
    {
        transform.localScale = new Vector3(0.0921f * move.health, 0.6f, 1f);
        transform.localPosition = new Vector3(-0.045875f * move.losthealth, 0f, 0f);
    }
}
