using UnityEngine;

public class PlayerColisionController : MonoBehaviour
{
    Rigidbody2D _playerBody;

    // Start is called before the first frame update
    void Start()
    {
        _playerBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemies"))
        {
            var magnitude = 2500;
            var force = transform.position - other.collider.transform.position;
            Debug.Log("Pain" + force);
            force.Normalize();
            _playerBody.AddForce(force * magnitude);
        }
    }
}