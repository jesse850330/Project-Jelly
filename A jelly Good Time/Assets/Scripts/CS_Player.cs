using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Player : MonoBehaviour
    {
        public float BulletInt;
        public float MalletInt;
        public int shellCount = 50;
        public int currentCount;
        private float currentFireTime;
        public float loadTime = 1.5f;//Reload
        private float currentLoadTime = 0;
        public int chargerCount = 5;//Mags
        // public AudioClip Fire;
        // public AudioClip Ability;
        public GameObject Bullet;
        public GameObject Bullet_Position;
        public GameObject Mallet;
        public GameObject Mallet_Position;
        CS_FPPAttack AIHp;

        void Update()
        {

            if (!isLoading()&& Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine(FireWeapon());
            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                StopAllCoroutines();
            }
            else if (currentCount == shellCount)
            {
                StopAllCoroutines();
            }
            if (Input.GetKey(KeyCode.R))
            {
                reLoading();
            }
            if (Input.GetKeyDown(KeyCode.Mouse1))
            {
                StartCoroutine(MalletAbility());
            }
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                StopAllCoroutines();
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other != null)
            {
                Destroy(gameObject);
            }
        }
        public bool isLoading()
        {
            if (chargerCount == 0) return true;
            if (currentCount < shellCount)
            {
                return false;
            }
            currentLoadTime += Time.deltaTime;
            if (currentLoadTime >= loadTime)
            {
                currentLoadTime = 0;
                return false;
            }
            return true;
        }

        public void reLoading()
        {
            if (currentCount >= 50)
            {
                chargerCount--;
                currentCount = 0;
            }
        }

        IEnumerator FireWeapon()
        {
            while (true)
            {
                Instantiate(Bullet, Bullet_Position.transform.position, Bullet_Position.transform.rotation);
                currentCount++;
                // AudioSource.PlayClipAtPoint(Fire, transform.localPosition);
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
                // AudioSource.PlayClipAtPoint(Ability, transform.localPosition);
                yield return new WaitForSeconds(MalletInt);
            }
        }
    }
}
