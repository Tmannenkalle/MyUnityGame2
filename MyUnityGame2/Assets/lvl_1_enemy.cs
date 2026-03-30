using UnityEngine;

public class lvl_1_enemy : MonoBehaviour
{
    public int hp = 1;
    void Start()
    {
        
    }

    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("attack"))
        {
            hp -= 1;
        }
    }
}
