using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseInteractable : MonoBehaviour, Interactable
{
    public TextMesh InteractText;
    public void Awake()
    {
        SetFloatingText();
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
    public abstract void Interact();
}
