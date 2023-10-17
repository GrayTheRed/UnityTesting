using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyOnInteract : MonoBehaviour
{
    public TextMesh InteractText;

    public void Awake()
    {
        
        SetFloatingText();
    }

    public void Interact()
    {
        Debug.Log("You hit the interact button");
        Destroy(gameObject);
    }
    public void ShowInteractText()
    {
        InteractText.gameObject.SetActive(true);
        Invoke("HideInteractText", 4.0f);
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
