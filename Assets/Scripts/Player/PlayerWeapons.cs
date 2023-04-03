using System.Collections;
using UnityEngine;
using Weapons;

public class PlayerWeapons : MonoBehaviour
{
    //Player Weapons
    public CircleBullet circleBullet;
    public SinBullet bullet;

    //Player Weapons
    private Rigidbody2D _playerBody;
    private PlayerInput _playerInput;

    void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
        _playerBody = GetComponent<Rigidbody2D>();
        ArmWeapons();
    }

    private void ArmWeapons()
    {
        var instantiate = Instantiate(circleBullet, _playerBody.position, Quaternion.identity) as IWeapon;
        StartCoroutine(nameof(SinSpawner));
    }

    IEnumerator SinSpawner()
    {
        Debug.Log("Happens before");
        Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, 0), _playerInput.Rotation);
        yield return new WaitForSeconds(2);
        Debug.Log("Happens after");
        StartCoroutine(nameof(SinSpawner));
    }
}