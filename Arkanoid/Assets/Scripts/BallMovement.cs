using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallMovement : MonoBehaviour
{
    public int score;
    public Text scoreText;
    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketWidth)
    {
        return (ballPos.x - racketPos.x) / racketWidth;
    }
    public float speed = 5.0f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.up * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position,
                                collision.transform.position,
                                collision.collider.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            rb.velocity = dir * speed;
        }

        if (collision.gameObject.layer == 8)
        {
            score += 1;
            scoreText.text = score.ToString();
        }
        if(collision.gameObject.name == "LosingLine")
        {
            SceneManager.LoadScene(0);
        }
    }
}
