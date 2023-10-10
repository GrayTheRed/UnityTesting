using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractBall : MonoBehaviour, Interactable
{
    //public KeyCode InteractKey;
    public bool IsOverlapping;
    public PlayerInput playerInput;
    public GameObject player;

    public void Awake()
    {
        player = GameObject.FindWithTag("Player");
        playerInput = player.GetComponent<PlayerInput>();
    }

    // Start is called before the first frame update
    void Start()
    {
        //InteractKey = KeyCode.E;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsOverlapping)
        {
            //if (Input.GetKeyDown(InteractKey))
            if (playerInput.actions["Interact"].WasPressedThisFrame())
            {
                Interact();
            }
        }
    }

    public void Interact()
    {
        Debug.Log("You hit the interact button");
    }

    void OnTriggerEnter (Collider other)
    {
        IsOverlapping = true;
        Debug.Log($"Interactable");
    }

    void OnTriggerExit (Collider other)
    {
        IsOverlapping = false;
    }
}
