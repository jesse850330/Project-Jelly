using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Player : MonoBehaviour
    {

        public float interval;
        public GameObject Bullet;

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

                Instantiate(Bullet, gameObject.transform.position, gameObject.transform.rotation);
                yield return new WaitForSeconds(interval);
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

        }
    }
}
