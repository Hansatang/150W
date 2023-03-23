using ObserverPattern;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]

    public class PlayerController : Subject
    {
        // Move player in 2D space
        public HealthBar healthBar;
        public Vector2 movementDirection;
        public float movementSpeed = 3f;
        public int playerMaxHealth = 100;
        public int playerCurrentHealth ;
        public int playerExperience;

        Rigidbody2D _playerBody;
        BoxCollider2D _playerCollider;
    
        void Start()
        {
            healthBar.SetMaxHealth(playerMaxHealth);
            playerCurrentHealth = playerMaxHealth;
            _playerBody = GetComponent<Rigidbody2D>();
            _playerCollider = GetComponent<BoxCollider2D>();
            NotifyObservers("Survival");
        }

        void Update()
        {
            movementDirection = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        }

        private void FixedUpdate()
        {
            _playerBody.velocity = movementDirection * movementSpeed;
        }
        
        void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("Pain");
            var magnitude = 250;
 
            var force = transform.position - other.transform.position;
 
            force.Normalize();
            _playerBody.velocity =-force * magnitude;
            
        }

        public void DamagePlayer(int damage)
        {
            Debug.Log("Touch Square");
            playerCurrentHealth -=damage;
            healthBar.SetHealth(playerCurrentHealth);
        }

        public void AwardExperience(int worth)
        {
            playerExperience += worth;
            Debug.Log("Exp"+ playerExperience);
        }

        public void KnockBack()
        {
            
        }
    }
}