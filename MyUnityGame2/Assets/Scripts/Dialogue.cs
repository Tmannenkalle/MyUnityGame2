using UnityEngine;
using TMPro;
using System.Security.Cryptography;

public class Dialogue : MonoBehaviour
{
    public string name;

    public string text;

    public TMP_Text name_place;

    public TMP_Text Text_place;

    public bool isnearby;

    public KeyCode E = KeyCode.E;

    public GameObject panel;

    [SerializeField] private  string nextline;

    [SerializeField] private bool nextlinestart;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        panel.SetActive(false);
        name_place.SetText("");
        Text_place.SetText("");
    }

    // Update is called once per frame
    void Update()
    {
       if (isnearby && Input.GetKeyDown(E))
        {
            panel.SetActive(true);
            name_place.SetText(name);
            Text_place.SetText(text);
            nextlinestart = true;
        }
        if(Input.GetKeyDown(E) && nextline != "" && nextlinestart)
            {
                name_place.SetText(name);
                Text_place.SetText(nextline);
                nextlinestart = false;
            }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Detector"))
        {
            isnearby = true;
        }
    }
     void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Detector"))
        {
            isnearby = false;
        }
    }
}
