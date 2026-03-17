using UnityEngine;
using TMPro;
using System.IO.Pipes;
using Microsoft.VisualBasic;

public class InteractionNpc : MonoBehaviour, IInteractable
{
    //må gjøre dette for å fikse error, bytt det tilbake når du må
    public Interaction dialogueData;
    public GameObject dialoguePanel;
    public TMP_Text dialougetext, nameText;
    private int dialogeIndex;
    private bool isTyping, isDialogeActive;

    public bool CanInteract()
    {
        return !isDialogeActive;
    }
    public void Interact()
    {
        if(dialogueData == null)
        {
            return;
        }
        if (isDialogeActive)
        {
            
        }
        else
        {
            
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
