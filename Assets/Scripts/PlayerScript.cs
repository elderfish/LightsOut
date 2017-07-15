using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    public float maxSpeed = 10f;

    Rigidbody2D rig;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;

    // Use this for initialization
    void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate() {
        float move = Input.GetAxis("Horizontal");

        rig.velocity = new Vector2(move * maxSpeed, rig.velocity.y);
    }

    //void OnCollisionEnter(Collision2D coll)
    //{
    //    if (coll.gameObject.CompareTag("Ground")){
    //        //do stuff
    //    }
    //}
}
