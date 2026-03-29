using UnityEngine;

public class Followobject : MonoBehaviour
{
    public Transform enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = enemy.position;
    }
}
