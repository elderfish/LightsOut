using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour {

    // this will hold a copy of the player
    public GameObject player;
    // this will hold the location of the last checkpoint the player was at
    public Vector3 prevCheck = new Vector3(0, 0, 0);

    public static bool borderCollide = true;

    //GameObject play;

    void Start()
    {
        // play = GetComponent<GameObject>();
    }

    void FixedUpdate()
    {
        if (transform.position.y < -20)
        {
            redo();
        }
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // if the player colides with an object that is tagged with, "Death"
        if (coll.gameObject.tag == "Death")
        {
            redo();
        } // if

        // if the player colides with an object that is tagged with "Check"
        if (coll.gameObject.tag == "Check")
        {
            // set prevCheck to player's current location
            prevCheck.Set(GameObject.FindGameObjectWithTag("Player").transform.position.x,
            GameObject.FindGameObjectWithTag("Player").transform.position.y, 
            GameObject.FindGameObjectWithTag("Player").transform.position.z);

        }

        if (coll.gameObject.tag == "Obstacle")
        {
            borderCollide = false;
        }
    } // void

    void OnCollisionExit(Collision collisionInfo)
    {
        borderCollide = true;
    }

// this function will set cordinates of a new player object
// to the last checkpoint
void Updating(Vector3 v)
    {
        prevCheck = v;
    }

    // call this function to kill player and spawn a copy
    void redo()
    {
        // a clone is spawned at cordinate 0, 0, 0
        GameObject playerClone = (GameObject)Instantiate(player, prevCheck, transform.rotation);
        // set the new player's prevCheck equal to current prevCheck
        playerClone.SendMessage("Updating", prevCheck);
        // the current player is destroyed
        Destroy(gameObject);
    }
}
