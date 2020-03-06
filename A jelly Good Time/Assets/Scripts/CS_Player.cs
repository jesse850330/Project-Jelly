using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Player : MonoBehaviour
    {

        public float BulletInt;
        public float MalletInt;
        public AudioClip Fire;
        public AudioClip Ability;
        public GameObject Bullet;
        public GameObject Bullet_Position;
        public GameObject Mallet;
        public GameObject Mallet_Position;
        CS_FPPAttack AIHp;

        private void OnTriggerEnter(Collider other)
        {
            if (other != null)
            {
                Destroy(gameObject);
            }
        }



        IEnumerator FireWeapon()
        {
            while (true)
            {
                Instantiate(Bullet, Bullet_Position.transform.position, Bullet_Position.transform.rotation);
                AudioSource.PlayClipAtPoint(Fire, transform.localPosition);
                yield return new WaitForSeconds(BulletInt);
            }

        }

        IEnumerator MalletAbility()
        {
            while (true)
            {
                var pos = Mallet_Position.transform.position;
                pos.y = 2;
                transform.position = pos;
                Instantiate(Mallet, Mallet_Position.transform.position = pos, Mallet_Position.transform.rotation);
                AudioSource.PlayClipAtPoint(Ability, transform.localPosition);
                yield return new WaitForSeconds(MalletInt);
            }
        }

        void Update()
        {

            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine(FireWeapon());
            }
            else if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                StopAllCoroutines();
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
            StartCoroutine(MalletAbility());
            }
        }

    }
}
