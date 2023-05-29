using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MoverNave : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float moveSpeed;
    
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext movementValue) //Este é chamado (invoke) no InputSystem em Nave
    {
        rb2d.velocity = movementValue.ReadValue<Vector2>() * moveSpeed; // Mover a Nave (Trancada no eixo Y no Rigidbody)
    }
}
