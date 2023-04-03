using ObserverPattern;
using UnityEngine;
using Weapons;

namespace Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    [RequireComponent(typeof(BoxCollider2D))]
    public class PlayerController : Subject
    {
        void Start()
        {
            NotifyObservers("Survival");
        }

        void Update()
        {
        }

        private void FixedUpdate()
        {
        }
    }
}