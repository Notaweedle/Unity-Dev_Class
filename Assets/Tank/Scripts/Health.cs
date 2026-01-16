using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float HpMax = 10;
    [SerializeField] GameObject hitEffect;
    [SerializeField] GameObject DestroyEffect;

    bool destroyed = false;
    
   
    public float CurrentHealth
    {

        get { return health; }

        set => health = Mathf.Clamp(value, 0, HpMax); 
    }

    float health;
    void Start()
    {
        
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
    public void onHeal(float amount) {
        CurrentHealth += amount;
    }
}
