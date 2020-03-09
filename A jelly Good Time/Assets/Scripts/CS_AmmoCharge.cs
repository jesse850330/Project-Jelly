using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_AmmoCharge : MonoBehaviour
    {
        Ray ray;
        float raylength = 1.5f;
        RaycastHit hit;
        CS_Player chargerCount;

        void Update()
        {
            ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
            if (Physics.Raycast(ray, out hit, raylength))
            {
                hit.transform.SendMessage("HitByRaycast", gameObject, SendMessageOptions.DontRequireReceiver);
            }
            else
            {
            }
        }
    }
}