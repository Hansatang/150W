using System;
using System.Collections;
using UnityEngine;
using Weapons;

public class SinBSpawner : MonoBehaviour, IWeaponSystem
{
    public SinBullet sinBullet;

    private GameObject _player;
    // Start is called before the first frame update

    public void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    public void Upgrade(float area, float power, float speed)
    {
        sinBullet.Upgrade(area, power, speed);
    }

    public void Arm()
    {
        StartCoroutine(nameof(SpawnSinBullet));
    }

    private IEnumerator SpawnSinBullet()
    {
        Instantiate(sinBullet, new Vector3(_player.transform.position.x, _player.transform.position.y, 0),
            _player.GetComponent<PlayerInput>().Rotation);
        yield return new WaitForSeconds(2);
        StartCoroutine(nameof(SpawnSinBullet));
    }


    public void Stop()
    {
        StopCoroutine(nameof(SpawnSinBullet));
    }
}