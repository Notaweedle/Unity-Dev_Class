using UnityEngine;
using UnityEngine.InputSystem;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float InAirDestroy = 5.0f;
    [SerializeField] float AfterCollision = 0.05f;
    

    [SerializeField] GameObject effect;
    Rigidbody rb;   
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
       rb.AddRelativeForce(Vector3.forward * (speed*speed), ForceMode.Impulse);
        Destroy(gameObject, InAirDestroy);
    }

    
    void Update()
    {
         
    }
    private void OnCollisionEnter(Collision collision)
    {
        // damg check
        Health health = collision.gameObject.GetComponent<Health>();
        if(health != null) 
        { 
            health.OnDamage(2);
        }
        //end damg

        Destroy(gameObject,AfterCollision);
        Instantiate(effect, transform.position, Quaternion.identity);
        DestroyImmediate(effect,true);

    }
}
