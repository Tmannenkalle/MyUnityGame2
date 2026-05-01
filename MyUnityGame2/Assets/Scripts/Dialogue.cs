using UnityEngine;
using TMPro;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

public class Dialogue : MonoBehaviour
{
    public string name;

    public string[] text;

    public TMP_Text name_place;

    public TMP_Text Text_place;

    public bool isnearby;

    public KeyCode E = KeyCode.E;

    public GameObject panel;

    [SerializeField] private int lines;
    public int Howmali;
    [SerializeField] private bool nextlinestart;

    public bool Endtalk;

    public string nextlines;
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
            if (lines >= text.Length)
        {
            lines = 0;
            panel.SetActive(false);
            name_place.SetText("");
            Text_place.SetText("");
            return;
        }
            panel.SetActive(true);
            name_place.SetText(name);
            Text_place.SetText(text[lines]);
            lines++;
            return;
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
