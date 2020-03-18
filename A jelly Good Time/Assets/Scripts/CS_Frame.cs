using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CS_Frame : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0, Random.Range(10.0f, 20.0f)*Time.deltaTime, Space.Self);
    }
}
