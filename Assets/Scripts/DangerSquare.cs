using UnityEngine;

public class DangerSquare : MonoBehaviour
{
    BoxCollider2D dangerCollider;

    private GameObject[] _objects;

    // Start is called before the first frame update
    void Start()
    {
        _objects = GameObject.FindGameObjectsWithTag("Player");
        dangerCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dangerCollider.IsTouching(_objects[0].GetComponent<CapsuleCollider2D>())) {
                Debug.Log("Touch Square");
                _objects[0].GetComponent<CharacterController2D>().playerCurrentHealth -= 5;
        }
    }
}
