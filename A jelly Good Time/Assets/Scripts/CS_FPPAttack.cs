using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_FPPAttack : MonoBehaviour
    {
        public float AIHp;
        // public AudioClip Jelly;

        private void OnTriggerEnter(Collider other)
        {
            if (other != null)
            {   
                AIHp -= 5;
                print(AIHp);
            }


        }
        private void Update()
        {

            if (AIHp <= 0)
            {
                Destroy(gameObject.transform.parent.gameObject);
                // AudioSource.PlayClipAtPoint(Jelly, transform.localPosition);
            }


        }

    }
}