using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    
    float paddleSpeed = 4f;

    Vector3 paddlePosition;

    float MinXPosition = -1.8f;
    float MaxXPosition = 1.8f;

    void Start()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        paddlePosition = this.transform.position;
    }

    

    // Update is called once per frame
    void Update()
    {
        float paddlePositionX = this.transform.position.x;

        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("key pressed");
            paddlePositionX -= paddleSpeed * Time.deltaTime;

        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            paddlePositionX += paddleSpeed * Time.deltaTime;

        }

        paddlePosition.x = Mathf.Clamp(paddlePositionX, MinXPosition, MaxXPosition);

        this.transform.position = paddlePosition;

    }
}
