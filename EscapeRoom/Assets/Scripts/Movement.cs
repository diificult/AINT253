﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public CharacterController c;
    public float speed = 5f;
    public bool grounded;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    public Transform camera;


    public Vector3 velocity;
    
    // Update is called once per frame
    void Update()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if  (grounded && velocity.y <0)
        {
            velocity.y = -2f;
        }
        Vector3 movement = camera.transform.right * Input.GetAxis("Horizontal") + camera.transform.forward * Input.GetAxis("Vertical");
        c.Move(movement * speed * Time.deltaTime);
        velocity.y += -9.81f * Time.deltaTime;
        c.Move(velocity *Time.deltaTime);
        AudioSource clip = groundCheck.GetComponent<AudioSource>();
        if (grounded && movement.magnitude > 0.5)
        {
            
            if (!clip.isPlaying)
            {
                clip.Play();
            }
        } else
        {
           // clip.Stop();
        }
       // Debug.Log(velocity);
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            velocity.y = Mathf.Sqrt(-9.81f *-2f);
        }
        
    }
}
