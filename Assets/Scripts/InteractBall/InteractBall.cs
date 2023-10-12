using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractBall : MonoBehaviour, Interactable
{
    public TextMesh InteractText;

    private bool IsOverlapping;
    private PlayerInput playerInput;
    private GameObject player;

    public void Awake()
    {       
        player = GameObject.FindWithTag("Player");
        playerInput = player.GetComponent<PlayerInput>();
        SetFloatingText();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (IsOverlapping)
        {
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
        InteractText.gameObject.SetActive(true);
        IsOverlapping = true;
        Debug.Log($"Interactable");
    }

    void OnTriggerExit (Collider other)
    {
        InteractText.gameObject.SetActive(false);
        IsOverlapping = false;
    }

    void SetFloatingText()
    {
        InteractText.text = "Press E To Interact";
        InteractText.color = Color.green;
        InteractText.anchor = TextAnchor.UpperCenter;
        InteractText.fontSize = 24;
        InteractText.richText = true;
    }
}
