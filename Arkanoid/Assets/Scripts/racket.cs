using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 3.0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb = GetComponent<Rigidbody2D>();
        float h = Input.GetAxisRaw("Horizontal");
        rb.velocity = Vector2.right * h * speed;
    }
}
