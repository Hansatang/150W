using System;
using UnityEngine;
using Weapons;

public class CircleBSpawner : MonoBehaviour, IWeaponSystem
{
    public CircleBullet circleBullet;
    private IWeapon circleWeapon;

    // Start is called before the first frame update
    private float _rotateSpeed = 2f;
    private float _radius = 2.0f;
    private float _power = 1.0f;

    private GameObject _player;
    private float _angle;

    // Start is called before the first frame update

    private void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Upgrade(float area, float power, float speed)
    {
        circleWeapon.Upgrade(area, power, speed);
    }

    public void Arm()
    {
        circleWeapon = Instantiate(circleBullet, _player.transform.position, Quaternion.identity);
    }

    public void Stop()
    {
        circleWeapon.Stop();
    }
}