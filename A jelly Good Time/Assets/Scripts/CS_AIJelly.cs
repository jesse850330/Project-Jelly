using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_AIJelly : MonoBehaviour
{
    public Transform PlayerTransform;
    public float speed = 5;
    public int step = 1;
    public int x = 0;
    public int z = 0;
    public float velocity = 0.5f;
    private Rigidbody rd;
    private Vector3 NextPosition;
    void Start()
    {
        NextPosition = transform.position;
		InvokeRepeating("EnemyMove", 1, velocity);
    }
	void FixedUpdate()
    {
        rd.MovePosition(Vector3.Lerp(transform.position, NextPosition, Time.deltaTime * speed));
    }

    public void EnemyMove()
    {

        Vector3 offset = PlayerTransform.position - transform.position;

        if (offset.magnitude < 12)
        { 

        }

        else
        { 
            if (Mathf.Abs(offset.z) > Mathf.Abs(offset.x))
            {

                if (offset.z > 0)
                { 
                   x = 0;
                   z = step;
                }
                else
                {
                   x = 0;
                   z = -step;
                   
                }
            }
            else
            {
                if (offset.x > 0)
                {
                   x = step;
                   z = 0;
                   
                }
                else
                {
                   x = -step;
                   z = 0;
                }
            }
            NextPosition = transform.position + new Vector3(x, 0, z);
        }
    }

}
