using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementX : MonoBehaviour
{
    private Rigidbody prb;
    private PlayerInput playerInput;
    private PlayerInputActions playerInputActions;

    private void Awake()
    { 
        prb = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Movement.performed += Up;
    }

    private void Update()
    {
        Vector2 inputVector = playerInputActions.Player.Movement.ReadValue<Vector2>();
        float speed = 100f;
        prb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }

    public void Up(InputAction.CallbackContext context)
    {
        //Vector3 tempVect = new Vector3(0, 0, 1);
        Vector2 inputVector = context.ReadValue<Vector2>();
        float speed = 100f;
        prb.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
        //tempVect = tempVect.normalized * speed * Time.deltaTime;
        //prb.MovePosition(transform.position + tempVect);
    }
}
 