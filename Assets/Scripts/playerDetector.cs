// this script is meant to detect if the player is inside of an object which is not activae

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDetector : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D coll)
    {
        DeathScript.borderCollide = false;
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        DeathScript.borderCollide = false;
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        DeathScript.borderCollide = true;
    }


}
