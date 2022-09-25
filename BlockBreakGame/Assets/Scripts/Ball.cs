using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    bool gameBegan = false;

    Rigidbody2D ballRigidbody;

    public bool clone;

    float ballVelocity = 5f;

    void Start()
    {
        ballRigidbody = GetComponent<Rigidbody2D>();
        if (clone)
        {
            ballRigidbody.velocity = new Vector2(ballVelocity, ballVelocity);
        }
    }

   
    void Update()
    {
        if (!clone)
        {
            if (!gameBegan)
            {

                this.transform.position = new Vector3(0, -3, 0);

            }
            if (Input.GetKey(KeyCode.Space))
            {
                gameBegan = true;

                

               
            }
        }
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float randomVelocityMin = 0f;

        float randomVelocityMax = 1f;

        Vector2 randomVelocity = new Vector2(Random.Range(randomVelocityMin, randomVelocityMax), Random.Range(randomVelocityMin, randomVelocityMax));



        ballRigidbody.velocity += randomVelocity;
        
    }
}
