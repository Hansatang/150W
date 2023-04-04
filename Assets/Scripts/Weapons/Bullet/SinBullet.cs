using UnityEngine;

namespace Weapons
{
    public class SinBullet : MonoBehaviour, IWeapon
    {
        private float _power = 1.0f;
        private float _moveSpeed = 5.0f;

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
            _pos += transform.up * (Time.deltaTime * _moveSpeed);
            transform.position = _pos + _axis * (Mathf.Sin(Time.time * frequency) * magnitude);
        }


        public void Upgrade(float area, float power, float speed)
        {
            magnitude = area * 2.0f;
            _moveSpeed = speed * 2.0f;
            _power = power * 2.0f;
        }


        public void Stop()
        {
            throw new System.NotImplementedException();
        }
    }
}