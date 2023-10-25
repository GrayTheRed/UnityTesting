
using UnityEngine;
using UnityEngine.Events;

public class PlayerStats : MonoBehaviour
{
    PlayerStatsScriptableObject playerStats;

   
    // Start is called before the first frame update

    void Start()
    {
        playerStats = (PlayerStatsScriptableObject)ScriptableObject.CreateInstance(typeof(PlayerStatsScriptableObject));
    }

}
