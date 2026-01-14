using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 45.0f;
    [SerializeField] float firerate = 1.0f;
    [SerializeField] Ammo ammo;
    [SerializeField] Transform muzzle;

    float fireTimer = 0;
    
    void Start()
    {
        fireTimer = firerate;
    }

    
    void Update()
    {
        firerate -= Time.deltaTime;
        if (fireTimer <= 0 ) 
        { 
            fireTimer += firerate;
            Instantiate(ammo, muzzle.position, muzzle.rotation);
            
        }
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }
}
