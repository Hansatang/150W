using ObserverPattern;
using UnityEngine;
using Weapons;


[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]
public class PlayerController : Subject
{
    void Start()
    {
        NotifyObservers("Survival");
    }
}