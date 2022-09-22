using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeController : MonoBehaviour
{
    [SerializeField] float speed;

    [SerializeField] float Lifetime;
    
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
        Destroy(gameObject, Lifetime);
    }
}
