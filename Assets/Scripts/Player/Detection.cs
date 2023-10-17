using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Detection : MonoBehaviour
{
    private PlayerInput input;
    private RaycastHit hit;
    public Camera playerCam;

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
        TryInteraction();
    }

    private void TryInteraction()
    {
        Interactable found = LookForInteractable();
        InteractWithInteractable(found);
    }
#nullable enable
    private Interactable? LookForInteractable()
    {
        if (Physics.Raycast(playerCam.transform.position, playerCam.transform.forward, out hit, 25.0f))
        {
            if(hit.collider.gameObject.TryGetComponent<Interactable>(out Interactable interact))
            {
                return interact;
            }
        } 
        return null;
    }

    private void InteractWithInteractable(Interactable? interactable)
    {
        if(null != interactable)
        {
            interactable.ShowInteractText();
            if (hit.distance <= 10.0f && input.actions["Interact"].WasPressedThisFrame())
            {
                interactable.Interact();
            }
        }
    }
}
