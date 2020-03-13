using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_PlayerControl : MonoBehaviour
{
    public float speed = 5.0f;

    void Start()
    {

    }

    void Update()
    {
        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0.0f, Input.GetAxis("Vertical") * speed * Time.deltaTime,Space.World);
    }

}
