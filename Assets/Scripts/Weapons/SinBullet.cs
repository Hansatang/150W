using UnityEngine;

namespace Weapons
{
    public class SinBullet : MonoBehaviour, IWeapon
    {
        private Vector2 _movementDirection;
        public float moveSpeed = 5.0f;

        public float frequency = 0.1f; // Speed of sine movement
        public float magnitude = 0.5f; // Size of sine movement
        private Vector3 _axis;

        private Vector3 _pos;

        void Start()
        {
            _pos = transform.position;
            Destroy(gameObject, 2.0f);
            _axis = transform.right;
        }

        void Update()
        {
            _pos += transform.up * (Time.deltaTime * moveSpeed);
            transform.position = _pos + _axis * (Mathf.Sin(Time.time * frequency) * magnitude);
        }


        public void Upgrade(float area, float power, float speed)
        {
            throw new System.NotImplementedException();
        }
    }
}