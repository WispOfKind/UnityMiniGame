using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerRigidbodyController : MonoBehaviour
{
    private Vector3 PlayerMovementInput;

    [SerializeField] private Rigidbody PlayerRigidbody;
    [SerializeField] private float Speed;
    [SerializeField] private FixedJoystick Joystick;

    [SerializeField] private LayerMask FloorMask;
    [SerializeField] private Transform FeetTransform;
    [SerializeField] private float JumpForce;

    
    void FixedUpdate()
    {
        //PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer();
    }

    private void MovePlayer()
    {
        PlayerRigidbody.velocity = new Vector3 (Joystick.Horizontal * Speed, PlayerRigidbody.velocity.y, Joystick.Vertical * Speed);
        
        //Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        //PlayerRigidbody.velocity = new Vector3(MoveVector.x, PlayerRigidbody.velocity.y, MoveVector.z);
        
    }

    public void Jump()
    {
        if (Physics.CheckSphere(FeetTransform.position, 0.1f, FloorMask))
        {
            PlayerRigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
        }
    }
}
