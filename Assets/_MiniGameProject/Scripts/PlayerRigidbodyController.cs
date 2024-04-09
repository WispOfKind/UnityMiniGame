using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class PlayerRigidbodyController : MonoBehaviour
{
    private Vector3 PlayerMovementInput;

    [SerializeField] private Rigidbody PlayerRigidbody;
    [SerializeField] private float Speed;

    [SerializeField] private LayerMask FloorMask;
    [SerializeField] private Transform FeetTransform;
    [SerializeField] private float JumpForce;

    
    void Start()
    {
        
    }

    void Update()
    {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerRigidbody.velocity = new Vector3(MoveVector.x, PlayerRigidbody.velocity.y, MoveVector.z);
        if (Physics.CheckSphere(FeetTransform.position, 0.1f, FloorMask))
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                PlayerRigidbody.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            }
        }
        
    }
}
