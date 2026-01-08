using UnityEngine;
using UnityEngine.InputSystem;

public class Spawner : MonoBehaviour
{
   [SerializeField] float time = 1.0f;
   [SerializeField] GameObject SpawnObject;
    

    private void Awake()
    {
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.isPressed) 
        {
            Vector3 pos = transform.position;
            pos.x += Random.Range(-5.0f, 5.0f);
            pos.y += Random.Range(-5.0f, 5.0f);
           var go= Instantiate(SpawnObject, transform.position, transform.rotation);
            Destroy(go, 4.0f);
        }
        
    }
}
