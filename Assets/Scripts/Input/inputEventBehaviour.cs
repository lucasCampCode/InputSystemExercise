using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class inputEventBehaviour : MonoBehaviour
{
    private PlayerMovementBehaviour _movement;
    [SerializeField]
    private ProjectileSpawnerBehaviour _gun;
    void Start()
    {
        _movement = GetComponent<PlayerMovementBehaviour>();
    }

    public void onMove(InputAction.CallbackContext ctx)
    {
        _movement.Move(ctx.ReadValue<Vector2>());
    }

    public void onFire(InputAction.CallbackContext ctx)
    {
        _gun.Fire();
    }
}
