using ObserverPattern;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]

    public class PlayerController : Subject
    {
        // Move player in 2D space
        public Vector2 movementDirection;
        public float movementSpeed = 3f;
        
        //PLayer health
        public HealthBar healthBar;
        public int playerMaxHealth = 100;
        public int playerCurrentHealth;
        
        //Player experience
        public int playerExperience;
        
        //Player Statistics
        public float area = 1.0f;
        public float power = 1.0f;
        public float speed = 1.0f;
        
        //Player Weapons
        public XXYYRR xxyyrr;
        
        //Player Components
        Rigidbody2D _playerBody;
        BoxCollider2D _playerCollider;
    
        void Start()
        {
            healthBar.SetMaxHealth(playerMaxHealth);
            playerCurrentHealth = playerMaxHealth;
            _playerBody = GetComponent<Rigidbody2D>();
            _playerCollider = GetComponent<BoxCollider2D>();
            NotifyObservers("Survival");
            XXYYRR weapon1 = Instantiate(xxyyrr, new Vector3(0, 0, 0), Quaternion.identity);
            weapon1.UpdateValues(area,power,speed);
        }

        void Update()
        {
            movementDirection = new Vector2(Input.GetAxis("Horizontal"),Input.GetAxis("Vertical"));
        }

        private void FixedUpdate()
        {
            _playerBody.MovePosition(_playerBody.position + movementDirection * (movementSpeed * Time.fixedDeltaTime));
        }
        
        void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("Pain");
            var magnitude = 2500;
 
            var force = transform.position - other.collider.transform.position;
            Debug.Log(force);
            force.Normalize();
            _playerBody.AddForce(force * magnitude);
            
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