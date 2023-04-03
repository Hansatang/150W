using UnityEngine;

public class PlayerExperience : MonoBehaviour
{
    //Player experience
    public int playerExperience;
    public int playerLevelUpExperience;

    private void Awake()
    {
        playerExperience = 0;
        playerLevelUpExperience = 100;
    }

    void Start()
    {
    }


    void Update()
    {
    }

    public void AwardExperience(int worth)
    {
        playerExperience += worth;
        Debug.Log("Exp" + playerExperience);
        if (playerExperience > playerLevelUpExperience)
        {
            Debug.Log("Level up" + playerExperience);
            playerLevelUpExperience *= 2;
        }
    }
}