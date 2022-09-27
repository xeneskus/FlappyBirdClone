using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdController : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody2D _rigidbody;

    private int score;

    [SerializeField] Text scoreText;


    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _rigidbody.velocity = Vector2.up * jumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Score")
        {
            score++;
            scoreText.text = score.ToString();
        }
              
    }
}
