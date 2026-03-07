using UnityEngine;

public class ChestInteraction : MonoBehaviour
{
    [SerializeField] private SpriteRenderer spriterender;
    private bool is_Opened = false;
    [SerializeField] private Sprite notOpenSprite;
    [SerializeField] private Sprite openSprite;
    void Start()
    {
        spriterender.sprite = notOpenSprite;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
         if (collision.gameObject.CompareTag("Player") && !is_Opened)
    {
        is_Opened = true;
        spriterender.sprite = openSprite;
    }}
    
    
}
