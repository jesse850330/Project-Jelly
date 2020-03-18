using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Charger : MonoBehaviour
    {
       
        public GameObject FireControl;

        void Start()
        {
      

        }

        void HitByRaycast()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FireControl.GetComponent<CS_Player>().shellCount = 30;
                FireControl.GetComponent<CS_Player>().chargerCount = 120;
                FireControl.GetComponent<CS_Player>().currentCount = 0;
               
            }
           
        }
    }
}
