using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Ammo ammo;
    [SerializeField] Transform muzzle;

    [SerializeField] float fireRate = 1.0f;
    [SerializeField] int maxAmmoCap = 30;

    private int ammoCount;

    public int AmmoCount
    {
        get { return ammoCount; }
        set { ammoCount = Mathf.Clamp(value,0,maxAmmoCap); }
    }
    public bool IsReadyToFire { get; set; } = true;

    

    void Start()
    {
        ammoCount = maxAmmoCap;
    }
    public void Onfire() 
    {
        if (IsReadyToFire && ammoCount > 0) 
        {
            ammoCount--;
            Instantiate(ammo,muzzle.position,transform.rotation);
            IsReadyToFire = false;
            StartCoroutine(ResetFireCR());
        }
    }

    IEnumerator ResetFireCR() 
    {
        yield return new WaitForSeconds(fireRate);
        IsReadyToFire = true;
    }
    
    void Update()
    {
        
    }
}
