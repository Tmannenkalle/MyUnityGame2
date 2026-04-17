using System.Runtime.CompilerServices;
using UnityEngine;

public class Interactbledetector : MonoBehaviour
{
    public Transform Player;
    [SerializeField]private IInteractable interactableInRange = null;
    [SerializeField]private GameObject interactionIcon;
    public KeyCode E = KeyCode.E;
    private Vector3 higher = new Vector3(0, 1, 0);

    public movement m;

    public bool isCloseToTheif;

    public bool closeold;

    public int old = 0;

    public RUUUUUNNN r;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        interactionIcon.SetActive(false);
    }

    public void OnInteract()
    {
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractable interact) && interact.CanInteract())
        {
            interactableInRange = interact;
            interactionIcon.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Theif"))
        {
            isCloseToTheif = true;
        }
        if (collision.gameObject.CompareTag("OldMan"))
        {
            closeold = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractable interact) && interact == interactableInRange)
        {
            interactableInRange = null;
            interactionIcon.SetActive(false);
        }
        if (collision.gameObject.CompareTag("Theif"))
        {
            isCloseToTheif = false;
        }
        if (collision.gameObject.CompareTag("OldMan"))
        {
            closeold = false;
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(E)){
            if (interactableInRange != null)
        {
            if (isCloseToTheif && old == 1)
                {
                    r.run = true;
                    r.canmove = true;
                }
            if (closeold)
                {
                    old++;
                }

       
            interactableInRange?.Interact();
        }
        }
        transform.position = Player.position;

    }
}
