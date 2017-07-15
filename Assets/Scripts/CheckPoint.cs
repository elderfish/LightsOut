using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D coll)
    {
        // if the player colides with an object that is tagged with, "Death"
        if (coll.gameObject.tag == "Player")
        {
            // make this play an animation and a sound
            // the current flag is destroyed
            Destroy(gameObject);
        } // if
    }
}
