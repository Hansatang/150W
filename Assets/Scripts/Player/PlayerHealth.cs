using Player;
using UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //PLayer health
    public HealthBar healthBar;
    public int playerMaxHealth = 100;
    public int playerCurrentHealth;

    private void Awake()
    {
        healthBar.SetMaxHealth(playerMaxHealth);
        playerCurrentHealth = playerMaxHealth;
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void DamagePlayer(int damage)
    {
        Debug.Log("Touch Square");
        playerCurrentHealth -= damage;
        healthBar.SetHealth(playerCurrentHealth);
    }
}