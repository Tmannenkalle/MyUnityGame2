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

    public bool isCloseToSword;

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
        if (collision.gameObject.CompareTag("Sword"))
        {
            isCloseToSword = true;
        }
        else
        {
            isCloseToSword = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out IInteractable interact) && interact == interactableInRange)
        {
            interactableInRange = null;
            interactionIcon.SetActive(false);
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(E)){
            if (interactableInRange != null)
        {
            if (isCloseToSword && m.haveSword)
                {
                    return;
                }

       
            interactableInRange?.Interact();
        }
        }
        transform.position = Player.position;

        if (isCloseToSword && m.haveSword)
        {
            
        }
    }
}
