using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float HpMax = 10;
    [SerializeField] GameObject hitEffect;
    [SerializeField] GameObject DestroyEffect;
    public float CurrentHealth { get; set; }
    bool destroyed = false;
    
   
    void Start()
    {
        CurrentHealth = HpMax;
    }

    
    void Update()
    {
        
    }

    public void OnDamage(float damage) 
    {
        CurrentHealth -= damage;
        if (CurrentHealth <= 0) destroyed = true;
       

        if (!destroyed && hitEffect != null) 
        { 
            Instantiate(hitEffect, transform.position, Quaternion.identity);
        }

        if (destroyed) 
        { if (DestroyEffect != null) 
            { Instantiate(DestroyEffect, transform.position, Quaternion.identity); }
        }
        Destroy(gameObject);
    }
}
