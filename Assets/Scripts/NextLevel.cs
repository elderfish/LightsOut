using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

    public string level;

    void OnCollisionEnter2D(Collision2D coll)
    {
        // if the player colides with an object that is tagged with, "Death"
        if (coll.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(level, LoadSceneMode.Single);
        } // if
    }
}
