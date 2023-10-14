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
    }

    public void Interact()
    {
        Debug.Log("You hit the interact button");
        this.gameObject.SetActive(false);
    }
    public void ShowInteractText()
    {
        InteractText.gameObject.SetActive(true);
    }
    
    public void HideInteractText()
    {
        InteractText.gameObject.SetActive(false);
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
