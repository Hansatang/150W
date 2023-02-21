
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(CapsuleCollider2D))]

public class CharacterController2D : Subject
{
    // Move player in 2D space
    public HealthBar healthBar;
    public Vector2 playerSpeed = new(3.0f, 3.0f);
    public int playerMaxHealth = 100;
    public int playerCurrentHealth ;
    public int playerExperience = 0;

    Rigidbody2D playerBody;
    CapsuleCollider2D playerCollider;
    
    void Start()
    {
        healthBar.SetMaxHealth(playerMaxHealth);
        playerCurrentHealth = playerMaxHealth;
        playerBody = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<CapsuleCollider2D>();
        playerBody.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
        NotifyObservers("Survival");
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {
        healthBar.SetHealth(playerCurrentHealth);
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(playerSpeed.x * inputX, playerSpeed.y * inputY, 0)*Time.deltaTime;
        playerBody.transform.Translate(movement);
        
        
        // var objects = GameObject.FindGameObjectsWithTag("Enemies");
        // if (playerCollider.IsTouching(objects[0].GetComponent<BoxCollider2D>())) {
        //         Debug.Log("Touch Square");
        //         playerHealth = playerHealth - 5;
        // }
    }
}