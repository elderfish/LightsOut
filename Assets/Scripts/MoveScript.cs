using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{

    public float speed = 10f;
    public char direction = 'r';
    public float time;
    // r for right, u for up, d for down, l for left 

    Rigidbody2D rig;

    // Use this for initialization
    void Start()
    {

        rig = GetComponent<Rigidbody2D>();
        Destroy(gameObject, time);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (direction == 'r')
            rig.velocity = new Vector2(speed, rig.velocity.y);
        else if (direction == 'u')
            rig.velocity = new Vector2(rig.velocity.x, speed);
        else if (direction == 'l')
            rig.velocity = new Vector2(-speed, rig.velocity.y);
        else if (direction == 'd')
            rig.velocity = new Vector2(rig.velocity.x, -speed);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        // if the object colides with the player
        if (coll.gameObject.tag == "Player")
            Destroy(gameObject);
    }
}
