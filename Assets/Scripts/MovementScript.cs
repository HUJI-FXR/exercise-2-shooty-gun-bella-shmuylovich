using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector2 = UnityEngine.Vector2;
using Vector3 = UnityEngine.Vector3;

public class MovementScript : MonoBehaviour
{
    #region VARIABLES

    [SerializeField] private float runningSpeed;
    [SerializeField] private float jumpingForce;

    private Rigidbody2D _rigidbody;
    private bool _isGrounded;

    #endregion

    #region MONOBEHAVIOUR

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Ground")) _isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground")) _isGrounded = false;
    }

    #endregion

    #region API

    public void Move(float direction)
    {
        _rigidbody.velocity = new Vector2(direction * runningSpeed * Time.deltaTime, _rigidbody.velocity.y);
    }

    public void Jump()
    {
        if (_isGrounded) _rigidbody.AddForce(Vector2.up * jumpingForce, ForceMode2D.Impulse);
    }

    #endregion
}
