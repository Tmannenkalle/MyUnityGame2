using UnityEngine;
using UnityEngine.UI;

public class damageFlash : MonoBehaviour
{
    public Image damageImage;
    public float flashSpeed = 5f;
    public float maxAlpha = 0.5f;

    private bool damaged;

    void Update()
    {
        if (damaged)
        {
            damageImage.color = new Color(1f, 0f, 0f, maxAlpha);
        }
        else
        {
            damageImage.color = Color.Lerp(
                damageImage.color,
                new Color(1f, 0f, 0f, 0f),
                flashSpeed * Time.deltaTime
            );
        }

        damaged = false;
    }

    public void TriggerFlash()
    {
        damaged = true;
    }
}