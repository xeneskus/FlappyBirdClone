using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class BirdController : MonoBehaviour
{
    [SerializeField] float jumpForce;
    [SerializeField] Rigidbody2D _rigidbody;

    private int score;

    [SerializeField] Text scoreText;
    [SerializeField] GameObject GameOverPanel;

    private void Start()
    {
        Time.timeScale = 1;
    }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Death")
        {
            Time.timeScale = 0;
            GameOverPanel.SetActive(true);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
