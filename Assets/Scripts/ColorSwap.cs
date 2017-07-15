// this script changes the background from black to white and white to black

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorSwap : MonoBehaviour {

    // these are the two colors
    public Color color1 = Color.white;
    public Color color2 = Color.black;
    public GameObject player;
    // bools are static so that onOrOff can access them
    // these hold info whether black or white is turned on, input checks if mouse has been clicked
    public static bool isWhite = true, isBlack = false;

    // our camera
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.clearFlags = CameraClearFlags.SolidColor;
    }

    void Update()
    {
        bool input = Input.GetButtonDown("Fire1");
        // if the left mouse button is clicked and the background is white
        if (input && isWhite && DeathScript.borderCollide && DeathScript.borderCollide)
        {
            // change background color, switch true false values
            cam.backgroundColor = color2;
            isWhite = false;
            isBlack = true;
        }
        else if (input && isBlack && DeathScript.borderCollide && DeathScript.borderCollide)
        {
            cam.backgroundColor = color1;
            isWhite = true;
            isBlack = false;
        }
    }
}
