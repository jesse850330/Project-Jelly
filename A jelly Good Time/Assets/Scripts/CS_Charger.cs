using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Charger : MonoBehaviour
    {
        public GameObject FireControl;

        void HitByRaycast()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                FireControl.GetComponent<CS_Player>().shellCount = 50;
                FireControl.GetComponent<CS_Player>().chargerCount = 250;
                FireControl.GetComponent<CS_Player>().currentCount = 0;
            }
        }
    }
}
