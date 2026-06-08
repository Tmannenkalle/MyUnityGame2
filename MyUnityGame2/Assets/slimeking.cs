using UnityEngine;

public class slimeking : MonoBehaviour
{
    public int hp = 50;
    public movement move;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Something entered: " + collision.name);
        if (collision.CompareTag("attack"))
        {
            hp--;

            if (move != null)
            {
                move.slimelosthealth++;
                move.slimehealth--;
            }

            if (hp <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}