using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Bullet : MonoBehaviour
    {
        public float speed;

        void Update()
        {
            // transform.Translate(0, 0, speed * Time.deltaTime);
            transform.Translate(Vector3.forward*speed*Time.deltaTime,Space.Self);
            Destroy(gameObject, 1.25f);
        }

    }
}