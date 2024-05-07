using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, ElysiumInput.IPlayerActions
{
    public ElysiumInput input;

    

    private void Awake()
    {
        
    }

    private void OnEnable()
    {
        if (input != null)
        {
            input = new ElysiumInput();
            input.Player.SetCallbacks(this);
        }
        input.Enable();
    }

    private void OnDisable()
    {
        input.Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        throw new NotImplementedException();
    }
}
