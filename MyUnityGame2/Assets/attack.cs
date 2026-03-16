using UnityEngine;

public class attack : MonoBehaviour
{
    public Transform player;
    public float atktime = 0.2f;
    public float cooldown = 1.5f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && cooldown <= 0f)
        {
            transform.localScale = new Vector3(13, 11, 1);
            atktime = 0.2f;
            cooldown = 1.5f;
        }
        transform.position = player.position;
    }
    void FixedUpdate()
    {
        if (atktime <= 0f)
            transform.localScale = new Vector3(0, 11, 1);

        atktime -= Time.fixedDeltaTime;
        cooldown -= Time.fixedDeltaTime;
    }
}
