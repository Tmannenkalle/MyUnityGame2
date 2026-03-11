using UnityEngine;

public class Stamina_bar : MonoBehaviour
{
    public movement move;

    void Update()
    {
        float lost_stamina = move.maxstamina - move.stamina;

        transform.localScale = new Vector3(0.0092f * move.stamina, 0.5625f, 1f);
        transform.localPosition = new Vector3(-0.00456f * lost_stamina, 0f, 0f);
    }
}