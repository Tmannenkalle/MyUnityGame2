using UnityEngine;

public class slimeking : MonoBehaviour
{
    public int hp = 50;
    public movement move;
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
            move.slimelosthealth += 1;
            move.slimehealth -= 1;
        }
    }
}
