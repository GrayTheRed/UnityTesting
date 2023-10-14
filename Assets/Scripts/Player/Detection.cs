using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Detection : MonoBehaviour
{
    private PlayerInput input;

    private void Awake()
    {
        input = GameObject.FindWithTag("Player").GetComponent<PlayerInput>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent<Interactable>(out Interactable interactable))
        {
            Debug.Log("Entering Trigger");
            interactable.ShowInteractText();
        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.TryGetComponent<Interactable>(out Interactable interactable))
        {
            Debug.Log("Exiting Trigger");
            interactable.HideInteractText();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.TryGetComponent<Interactable>(out Interactable interactable))
        {
            if (input.actions["Interact"].WasPressedThisFrame())
            {
                interactable.Interact();
            }
        }
    }
}
