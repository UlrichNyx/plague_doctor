using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInput : MonoBehaviour
{
    private InputActions playerActions;

    private void Awake()
    {
        playerActions = new InputActions();
        playerActions.Player.Enable();
        playerActions.Player.Interact.performed += Interact_performed;
    }

    private void Interact_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        throw new System.NotImplementedException();
    }

    public Vector2 GetMovementVectorNormalized()
    {
        Vector2 inputVector = playerActions.Player.Move.ReadValue<Vector2>();
        inputVector = inputVector.normalized;
        return inputVector;
    }
}
