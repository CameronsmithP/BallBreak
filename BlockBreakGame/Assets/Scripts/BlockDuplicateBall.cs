using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDuplicateBall : MonoBehaviour
{
    public GameObject ballPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject ballObject = Instantiate(ballPrefab);
        Ball ball = ballObject.GetComponent<Ball>();
        ball.clone = true;

        ball.transform.position = collision.gameObject.transform.position;
    }
}
