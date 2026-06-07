using UnityEditor.Rendering.Universal;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.Rendering;

public class Click : MonoBehaviour
{
    public GameObject per;

    public bool on_button1;
    public bool on_button2;

    public CameraFollow cf;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousepositon = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepositon.z = 0f;
       per.transform.position = mousepositon;
       if(on_button1 && Input.GetMouseButtonDown(0))
        {
            cf.IntUp();
        }
        if(on_button2 && Input.GetMouseButtonDown(0))
        {
            cf.started = true;
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Button"))
        {
            on_button1 = true;
        }
        if(collision.gameObject.CompareTag("Button2"))
        {
            on_button2 = true;
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Button"))
        {
            on_button1 = false;
        }
        if(collision.gameObject.CompareTag("Button2"))
        {
            on_button2 = false;
        }
    }

}
