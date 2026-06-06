using UnityEngine;
using UnityEngine.AdaptivePerformance;

public class Click : MonoBehaviour
{
    public GameObject per;

    public bool on_button;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       per.transform.position = Input.mousePosition;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Button"))
        {
            
        }
    }

}
