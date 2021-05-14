using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputDelegateBehaviour : MonoBehaviour
{
    private PlayerControls _playerControls;
    private PlayerMovementBehaviour _playerMovement;
    [SerializeField]
    private ProjectileSpawnerBehaviour _projectileSpawner;

    private void Awake()
    {
        _playerControls = new PlayerControls();
    }
    private void OnEnable()
    {
        _playerControls.Enable();
    }
    private void OnDisable()
    {
        _playerControls.Disable();
    }
    // Start is called before the first frame update
    void Start()
    {
        _playerMovement = GetComponent<PlayerMovementBehaviour>();
        
        _playerControls.Player.Fire.performed += ctx => _projectileSpawner.Fire();
    }
    void FixedUpdate()
    {
        _playerMovement.Move(_playerControls.Player.Movement.ReadValue<Vector2>());
    }
}
