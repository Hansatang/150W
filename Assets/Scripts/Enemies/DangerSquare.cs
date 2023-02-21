using Player;
using UnityEngine;

namespace Enemies
{
    public class DangerSquare : MonoBehaviour
    {
        BoxCollider2D _dangerCollider;

        private GameObject[] _objects;

        // Start is called before the first frame update
        void Start()
        {
            _objects = GameObject.FindGameObjectsWithTag("Player");
            _dangerCollider = GetComponent<BoxCollider2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (_dangerCollider.IsTouching(_objects[0].GetComponent<CapsuleCollider2D>())) {
                Debug.Log("Touch Square");
                _objects[0].GetComponent<PlayerController>().playerCurrentHealth -= 5;
            }
        }
    }
}
