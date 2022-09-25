using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    Restart restart;

    void Start()
    {
        restart = FindObjectOfType<Restart>();
        //find any objects that have a Restart script
    }


    private void OnTriggerEnter2D(Collider2D trigger)
    { //checks collision then executes
        

        GameObject[] ballObjects = GameObject.FindGameObjectsWithTag("Ball");
        //stores all game objects tagged ball to a array

        if (ballObjects.Length < 2)
        {
            Debug.Log("Death zone");
            restart.RestartLevel();
        }
        else
        {
            Destroy(trigger.gameObject);
        }
    }

    

    
}
