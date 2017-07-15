using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour {

    public Transform prefab;
    private int timer = 0;
    public float seconds;
    private float actual;

    // Use this for initialization
    void Start () {

        actual = seconds * 30;

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        timer++;
        if (timer >= actual)
        {
            Instantiate(prefab, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
            timer = 0;
        }

    }
}
