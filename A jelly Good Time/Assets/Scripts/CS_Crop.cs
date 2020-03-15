using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Crop : MonoBehaviour
    {
        public float CropHp;


        private void OnTriggerEnter(Collider theCollision)
        {
            if (theCollision.tag == "Enemy")
            {
                CropHp -= 1;
            }
        }
        private void Update()
        {
            if (CropHp <= 0)
            {
                Destroy(gameObject, 1f);
            }

        }
    }
}