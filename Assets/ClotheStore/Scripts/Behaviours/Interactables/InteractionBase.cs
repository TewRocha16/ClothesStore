using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionBase : MonoBehaviour
{
    internal bool isColliding;
    [SerializeField] private GameObject interactionFeedback;
    private void Update()
    {
        CanInteractCheck();
    }
    private void CanInteractCheck()
    {
        bool interactionInput = Input.GetKeyDown(KeyCode.E);
        if (isColliding)
        {
            interactionFeedback.SetActive(true);
            if (interactionInput)
                Interact();
        }
        else
            interactionFeedback.SetActive(false);
    }
    public virtual void Interact()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isColliding = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            isColliding = false;
        }
    }
}
