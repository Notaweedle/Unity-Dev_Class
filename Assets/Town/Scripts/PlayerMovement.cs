using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{
    
    public Camera playerCamera;
    public float walkSpeed = 6f;
   
    
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    

    void Start()
    {
        
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        if (Keyboard.current.wKey.isPressed) 
        {
            
        }

       
    }
}

