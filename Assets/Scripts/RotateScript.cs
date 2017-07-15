using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateScript : MonoBehaviour {

    // this determines which direction the object will rotate
    public int rotation = 1;
    // this determines the speed of the rotation
    public int rotateSpeed = 10;
	
	// FixedUpdate is called once per frame
	void FixedUpdate ()
    {

        this.transform.Rotate(new Vector3(0, 0, rotation * rotateSpeed * Time.deltaTime));
 
    }
}
