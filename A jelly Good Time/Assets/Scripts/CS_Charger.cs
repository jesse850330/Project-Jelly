using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Charger : MonoBehaviour
    {
        Renderer R1;
        public GameObject FireControl;

        void Start()
        {
            R1 = gameObject.GetComponent<Renderer>();
            R1.material.color = Color.green;

        }

        void HitByRaycast()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FireControl.GetComponent<CS_Player>().chargerCount = 250;
                R1.material.color = Color.red;
            }
            if (Input.GetKeyUp(KeyCode.E))
            {
                R1.material.color = Color.green;
            }

        }
    }
}
