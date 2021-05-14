using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputBehaviour : MonoBehaviour
{
    [SerializeField]
    private ProjectileSpawnerBehaviour _projectileSpawner;

    public void onFire(InputAction.CallbackContext ctx)
    {
        if (ctx.performed)
            _projectileSpawner.Fire();
    }
}
