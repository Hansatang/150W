using Player;
using UnityEngine;

namespace Experience
{
    public class ExperienceOrbBehaviour : MonoBehaviour
    {
        public int worth = 10;
        PolygonCollider2D experienceCollider;
    
        // Start is called before the first frame update
        void Start()
        {
            experienceCollider = GetComponent<PolygonCollider2D>();
        }

        // Update is called once per frame
        void Update()
        {

        }
    
 
    
        private void FixedUpdate()
        {
            // var objects = GameObject.FindGameObjectsWithTag("Player");
            // if (experienceCollider.IsTouching(objects[0].GetComponent<CapsuleCollider2D>())) {
            //     Debug.Log("Touch exp");
            //     Destroy(gameObject);
            // }
        }
    
        void OnCollisionEnter2D(Collision2D other)
        {
            
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Touch Square");
                Debug.Log("Exp"+ other.gameObject.GetComponent<PlayerController>());
                other.gameObject.GetComponent<PlayerController>().AwardExperience(worth);
                Destroy(gameObject);
                
            }
     
        }
    }
}
