using UnityEngine;
using UnityEngine.InputSystem;

public class Rocket : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float InAirDestroy = 5.0f;
    [SerializeField] float AfterCollision = 0.05f;

    [SerializeField] GameObject effect;
    Rigidbody rb;   
    void Start()
    {
       rb = GetComponent<Rigidbody>(); 
       rb.AddRelativeForce(Vector3.forward * (speed * speed), ForceMode.Impulse);
        Destroy(gameObject, InAirDestroy);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    private void OnCollisionEnter(Collision collision)
    {
       
        Destroy(gameObject,AfterCollision);
        Instantiate(effect, transform.position, Quaternion.identity);
        Destroy(effect, AfterCollision);

    }
}
