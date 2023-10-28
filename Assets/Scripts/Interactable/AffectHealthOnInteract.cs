using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffectHealthOnInteract : BaseInteractable
{
    public int Affect;
    [SerializeField]
    public PlayerStatsScriptableObject stats;

    private void OnEnable()
    {
        stats = (PlayerStatsScriptableObject)ScriptableObject.CreateInstance(typeof(PlayerStatsScriptableObject));
    }

    public override void Interact()
    {
        stats.ChangeHealth(Affect);
    }
}
