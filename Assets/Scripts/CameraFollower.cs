using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    public void Update()
    {
        //transform.position = myPlay.position + myPos;
        Vector3 subtraction = new Vector3(0, 0, 1);
        cam.transform.position = GameObject.FindGameObjectWithTag("Player").transform.position - subtraction;

    }
}