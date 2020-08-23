﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunMove : MonoBehaviour

{
    public Rigidbody player;
    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player.velocity = new Vector3((Input.GetAxis("Horizontal") * speed ), player.velocity.y, Input.GetAxis("Vertical") * speed );
        if (Input.GetKey("d"))
        {
            transform.Rotate(new Vector3(0f, -1f, 0f) *speed);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(new Vector3(0f, 1f, 0f) *speed);
        }
    }
}

