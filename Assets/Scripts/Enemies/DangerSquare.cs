using UnityEngine;

namespace Enemies
{
    public class DangerSquare : MonoBehaviour,Enemy
    {
        private float _health = 10.0f;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Touch Square");
                other.gameObject.GetComponent<PlayerHealth>().DamagePlayer(5);
            }
        }

        public void TakeDamage(float damage)
        {
            _health -= damage;
            Debug.Log("PAIN");
            if (_health <= 0)
            {
                Debug.Log("I died");
            }
        }
    }
}