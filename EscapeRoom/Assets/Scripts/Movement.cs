using System.Collections;
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


    public Vector3 velocity;
    
    // Update is called once per frame
    void Update()
    {
        grounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if  (grounded && velocity.y <0)
        {
            velocity.y = -2f;
        }
        Vector3 movement = transform.right * Input.GetAxis("Horizontal") + transform.forward * Input.GetAxis("Vertical");
        c.Move(movement * speed * Time.deltaTime);
        velocity.y += -9.81f * Time.deltaTime;
        c.Move(velocity *Time.deltaTime);
       // Debug.Log(velocity);
        if(Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            velocity.y = Mathf.Sqrt(1f * -9.81f *-2f);
        }
        
    }
}
