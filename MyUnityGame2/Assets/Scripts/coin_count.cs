using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class coin_count : MonoBehaviour
{
    public TMP_Text coincount;
    public movement move;
    void Start()
    {
    }

    void Update()
    {
        if (move.coinsoptimization != move.coins)
        {
            move.coinsoptimization = move.coins;
            coincount.text = $"{move.coins}";
        }            
    }
}
