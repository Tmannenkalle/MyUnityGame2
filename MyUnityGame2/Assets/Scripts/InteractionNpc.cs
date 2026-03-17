using UnityEngine;
using TMPro;
using System.IO.Pipes;
using Microsoft.VisualBasic;
using System.Collections;

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
            NextLine();
        }
        else
        {
            StartDialoge();
        }
        void StartDialoge()
        {
            isDialogeActive = true;
            dialogeIndex = 0;

            nameText.SetText(dialogueData.npcNavn);
            dialoguePanel.SetActive(true);
            StartCoroutine(TypeLine());
            }
            void NextLine()
        {
            if(isTyping)
            {
                StopAllCoroutines();
                dialougetext.SetText(dialogueData.dialogeLines[dialogeIndex]);
                isTyping = false;
            }
            else if(++dialogeIndex < dialogueData.dialogeLines.Length)
            {
                StartCoroutine(TypeLine());
            }
            else
            {
                EndDialoge();
            }
        }
        IEnumerator TypeLine()
        {
            isTyping = true;
            dialougetext.SetText("");

            foreach(char letter in dialogueData.dialogeLines[dialogeIndex])
            {
                dialougetext.text += letter;
                yield return new WaitForSeconds(dialogueData.typingSpeed);
            }
            isTyping = false;

            if(dialogueData. autodialogelines.Length > dialogeIndex && dialogueData.autodialogelines[dialogeIndex])
            {
                yield return new WaitForSeconds(dialogueData.autodialogelinesdelay);
                NextLine();
            }
        }
            }
    public void EndDialoge()
    {
        StopAllCoroutines();
        isDialogeActive = false;
        dialougetext.SetText("");
        dialoguePanel.SetActive(false);
    }
}
