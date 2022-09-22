using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody2D _rigidbody;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.velocity = Vector2.up * jumpForce;
        }
    }
}
