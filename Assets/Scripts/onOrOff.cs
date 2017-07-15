// this script is meant to be attached to platforms that only
// appear depending on whether the background is white or black,
// it makes them visable and active while one color is on, then invisible
// and invactive while another color is shown

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onOrOff : MonoBehaviour {

    // this holds the info for the light the block will be active
    public string lightColor;
    BoxCollider2D box;

    void Start()
    {
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void FixedUpdate () {
        Vector3 ok = new Vector3(transform.position.x, transform.position.y, 0);
        Vector3 no = new Vector3(transform.position.x, transform.position.y, -12);

        // these check the ColorSwap script to see
        // if the background is black or white
        bool wcheck = ColorSwap.isWhite;
        bool bcheck = ColorSwap.isBlack;
        
        if (bcheck && lightColor == "Dark")
        {
            // change the is trigger on the box
            box.isTrigger = false;
            gameObject.transform.position = ok;
        }
        else if (wcheck && lightColor == "Dark")
        {
            box.isTrigger = true;
            gameObject.transform.position = no;
        }

        if (wcheck && lightColor == "Light")
        {
            box.isTrigger = false;
            gameObject.transform.position = ok;
        }
        else if (bcheck && lightColor == "Light")
        {
            box.isTrigger = true;
            gameObject.transform.position = no;
        }

    }
}
