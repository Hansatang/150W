using ObserverPattern;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(CapsuleCollider2D))]

    public class PlayerController : Subject
    {
        // Move player in 2D space
        public HealthBar healthBar;
        public Vector2 playerSpeed = new(3.0f, 3.0f);
        public int playerMaxHealth = 100;
        public int playerCurrentHealth ;
        public int playerExperience = 0;

        Rigidbody2D _playerBody;
        CapsuleCollider2D _playerCollider;
    
        void Start()
        {
            healthBar.SetMaxHealth(playerMaxHealth);
            playerCurrentHealth = playerMaxHealth;
            _playerBody = GetComponent<Rigidbody2D>();
            _playerCollider = GetComponent<CapsuleCollider2D>();
            _playerBody.collisionDetectionMode = CollisionDetectionMode2D.Continuous;
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
            _playerBody.transform.Translate(movement);
        
        
            // var objects = GameObject.FindGameObjectsWithTag("Enemies");
            // if (playerCollider.IsTouching(objects[0].GetComponent<BoxCollider2D>())) {
            //         Debug.Log("Touch Square");
            //         playerHealth = playerHealth - 5;
            // }
        }
    }
}