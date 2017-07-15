// the purpose of this script is to check whether or not the player is
// inside of another when they click to change the lights

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChangeCheck : MonoBehaviour {

    bool borderCollide;

	// Use this for initialization
	void Start () {
		
	}

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "Obstacle")
        {
            borderCollide = true;
        }//END IF COLLISION.COLLIDER == "BORDER_COLLIDER_HERE"

    //    if (collision_info.collider.name == "playspace_collider_name")
    //    {
    //        playspace_collide = true;
    //    }//END IF COLLISION.COLLIDER == "PLAYSPACE_COLLIDER_HERE"

    //    print(gameObject.name + " in contact with " + collisionInfo.collider.name);
    //}//END FUNCTION ONCOLLISIONENTER

    //void OnCollisionExit(Collision collisionInfo)
    //{
    //    print(gameObject.name + " No longer in contact with " + collisionInfo.collider.name);
    //}

    //// Update is called once per frame
    //void Update () {
		
	}
}
