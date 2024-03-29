using UnityEngine;
using Weapons;

public class CircleBullet : MonoBehaviour, IWeapon
{
    // Start is called before the first frame update
    private float _rotateSpeed = 2f;
    private float _radius = 2.0f;
    private float _power = 1.0f;

    private GameObject _player;
    private float _angle;

    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        _angle += _rotateSpeed * Time.deltaTime;

        var offset = new Vector3(Mathf.Sin(_angle), Mathf.Cos(_angle), 0) * _radius;
        transform.position = _player.transform.position + offset;
    }

    public void Upgrade(float area, float power, float speed)
    {
        _radius = area * 2.0f;
        _rotateSpeed = speed * 2.0f;
        _power = power * 2.0f;
    }

    public void Stop()
    {
        Destroy(gameObject);
    }
    
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemies"))
        {
            other.gameObject.GetComponent<Enemy>().TakeDamage(_power);
            Destroy(gameObject);
        }
    }
}