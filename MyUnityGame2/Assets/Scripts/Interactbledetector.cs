using UnityEngine;

public class Interactbledetector : MonoBehaviour
{
    [SerializeField]private IInteractable interactableInRange = null;
    [SerializeField]private GameObject interactionIcon;
    [SerializeField]private KeyCode E = KeyCode.E;
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
        interactableInRange?.Interact();}
    }
}
