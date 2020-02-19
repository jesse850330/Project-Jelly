using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_FPPControl : MonoBehaviour
{
    public CharacterController controller;
    public Rigidbody rigidbody;
    public float speed = 5;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        controller = this.GetComponent<CharacterController>();
    }

    //Move
    

    // Update is called once per frame
    void Update()
    {
        //Move
        if (Input.GetKey("a"))
            controller.SimpleMove(transform.right * -speed);
        if (Input.GetKey("d"))
            controller.SimpleMove(transform.right * speed);
        if (Input.GetKey("w"))
            controller.SimpleMove(transform.forward * speed);
        if (Input.GetKey("s"))
            controller.SimpleMove(transform.forward * -speed);
    }
}
