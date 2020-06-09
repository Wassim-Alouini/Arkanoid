using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockBehaviour : MonoBehaviour
{


    void Start()
    {
        gameObject.layer = 8;
    }


    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
 


        if(collision.gameObject.name == "Ball")
        {
            Destroy(gameObject);

        }
    }
}
