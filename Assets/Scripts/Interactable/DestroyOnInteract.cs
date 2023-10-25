using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DestroyOnInteract : BaseInteractable
{ 
    public override void Interact()
    {
        Debug.Log("You hit the interact button");
        Destroy(gameObject);
    }
   
}
