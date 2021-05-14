using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementBehaviour : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private Vector3 _velocity;
    [SerializeField]
    private float _moveSpeed = 1;

    public void Move(Vector3 direction)
    {
        _velocity = direction * _moveSpeed * Time.deltaTime;
    }
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _rigidbody.MovePosition(transform.position + _velocity);
    }
}
