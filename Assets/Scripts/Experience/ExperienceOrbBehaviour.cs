using UnityEngine;

namespace Experience
{
    public class ExperienceOrbBehaviour : MonoBehaviour
    {
        public int worth = 10;
        
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
                Debug.Log("Exp" + other.gameObject.GetComponent<PlayerExperience>());
                other.gameObject.GetComponent<PlayerExperience>().AwardExperience(worth);
                Destroy(gameObject);
            }
        }
    }
}