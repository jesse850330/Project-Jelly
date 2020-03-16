using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_FPPAttack : MonoBehaviour
    {
        public float AIHp;
        public float Score;


        // public AudioClip Jelly;

        private void OnTriggerEnter(Collider theCollision)
        {
            if (theCollision.tag == "Bullet")
            {
                AIHp -= 5;
            }
            if (theCollision.tag == "Mallet")
            {
                AIHp -= 100;
            }

        }

        private void Update()
        {
            if (AIHp <= 0)
            {
                Destroy(gameObject.transform.parent.gameObject);
                CS_Score.x += Score;
                CS_Score.Score.text = "Score : " + CS_Score.x;
                CS_AISpawn.kill++;
                // AudioSource.PlayClipAtPoint(Jelly, transform.localPosition);
            }


        }

    }
}