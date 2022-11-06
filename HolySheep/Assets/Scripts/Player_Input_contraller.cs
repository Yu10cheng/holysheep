using UnityEngine.InputSystem;
using UnityEngine;

public class Player_Input_contraller : MonoBehaviour
{
    private PlayerInput _playerinput;
    public Vector2 MoveInput { get; private set; } = Vector2.zero;

    private void OnAwake()
    {
      _playerinput = GetComponent<PlayerInput>();

        Player_main_control _inputManager =  new Player_main_control();
       // _inputManager.primary.
    }

    private void OnEnable()
    {
        Player_main_control _inputManager = new Player_main_control();
        _inputManager.primary.Enable();

       // _inputManager.primary.move.triggered += SetMove;
        //_inputManager.primary.move.started += SetMove;//fires once 

        _inputManager.primary.move.performed += SetMove;//floating value
        _inputManager.primary.move.canceled += SetMove;//no input

    }
    private void OnDisable()
    {
        Player_main_control _inputManager = new Player_main_control();
        _inputManager.primary.move.performed -= SetMove;//floating value
        _inputManager.primary.move.canceled -= SetMove;//no input
    }

    private void SetMove(InputAction.CallbackContext context)
    {
        MoveInput = context.ReadValue<Vector2>();
    }




}
