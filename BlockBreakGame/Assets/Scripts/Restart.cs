using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void RestartLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void CheckIfAllBlocksDestroyed()
    {

        GameObject[] blocks = GameObject.FindGameObjectsWithTag("Block");

        if (blocks.Length < 2)
        {

            RestartLevel();

        }

    }



}
