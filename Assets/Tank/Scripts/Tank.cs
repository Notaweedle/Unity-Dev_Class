using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class Tank : MonoBehaviour
{
    [SerializeField] float speed = 5.0f;
    [SerializeField] float rotationSpeed = 90.0f; // rotation in degrees per second

    [SerializeField] Ammo ammo;
    [SerializeField] GameObject muzzle;
    [SerializeField] int Ammo = 10;

    [SerializeField] Slider HealthBar;

    InputAction moveAction;
    InputAction lookAction;
    InputAction attackAction;

    Health health;
    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        lookAction = InputSystem.actions.FindAction("Look");
        attackAction = InputSystem.actions.FindAction("Attack");

        attackAction.started += ctx => OnAttack();
        health = GetComponent<Health>();
    }

    void Update()
    {
        
        float direction = moveAction.ReadValue<Vector2>().y;
        if (Keyboard.current.wKey.isPressed) direction = +1.0f;
        if (Keyboard.current.sKey.isPressed) direction = -1.0f;

       
        transform.Translate(Vector3.forward * direction * speed * Time.deltaTime);

       
        float rotation = lookAction.ReadValue<Vector2>().x;
        if (Keyboard.current.aKey.isPressed) rotation = -1.0f;
        if (Keyboard.current.dKey.isPressed) rotation = +1.0f;

     
        transform.Rotate(Vector3.up * rotation * rotationSpeed * Time.deltaTime);
        
        
    }
    void OnAttack() { Instantiate(ammo, muzzle.transform.position, muzzle.transform.rotation); }
    
}
