using UnityEngine;
using TMPro;

public class dashtext : MonoBehaviour
{
    public movement move;
    private TextMeshProUGUI dashcooldown;
    void Start()
    {
        dashcooldown = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        if (move.timer <= 0f)
        {
           dashcooldown.text = "Dash: Ready"; 
           dashcooldown.color = Color.mediumSeaGreen;
        }
        else
        {
            dashcooldown.color = Color.mediumSlateBlue;
            dashcooldown.text = $"Dash: {Mathf.Round(move.timer * 10) / 10}";
        }
    }
}
