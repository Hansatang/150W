using UnityEngine;

namespace Enemies
{
    public class DangerSquare : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Touch Square");
                other.gameObject.GetComponent<PlayerHealth>().DamagePlayer(5);
            }
        }
    }
}