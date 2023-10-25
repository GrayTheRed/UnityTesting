
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "PlayerStatsScriptableObject", menuName = "ScriptableObjects/PLayerStats")]

public class PlayerStatsScriptableObject : ScriptableObject
{
    public int CurrentHealth = 100;
    public int MaxHealth = 100;
    public float Speed = 5f;

    [System.NonSerialized]
    public UnityEvent<int> healthChangeEvent;
    
    private void OnEnable()
    {
        CurrentHealth = MaxHealth;
        if (healthChangeEvent == null)
        {
            healthChangeEvent = new UnityEvent<int>();
        }
    }
    
    public void DecreaseHealth(int amount)
    {
        CurrentHealth -= amount;
        healthChangeEvent.Invoke(amount);
    }
}
