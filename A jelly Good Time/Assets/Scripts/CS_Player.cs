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
        public int abilityCharge = 0;
        private int charge;
        // public AudioClip Fire;
        // public AudioClip Ability;
        public GameObject Bullet;
        public GameObject Bullet_Position;
        public GameObject Mallet;
        public GameObject Mallet_Position;
        CS_FPPAttack AIHp;
        CS_Score Score;
        // RaycastHit hitInfo;
        private bool Ability1 = false;
        private bool Ability2 = false;
        private bool Ability3 = false;


        void Update()
        {
            if (!isLoading() && Input.GetKeyDown(KeyCode.Mouse0))
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
            if (!MalletIntAbility() && Input.GetKeyDown(KeyCode.Mouse1))
            {
                StartCoroutine(MalletAbility());
            }
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                StopAllCoroutines();
            }
            if (chargerCount >= 0)
            {
                CS_Score.c = abilityCharge;
                CS_Score.y = chargerCount;
                CS_Score.z = shellCount - currentCount;
                CS_Score.AbilityM.text = "Ability: " + CS_Score.c;
                CS_Score.Mag.text = "Mag: " + CS_Score.y;
                CS_Score.Ammo.text = "Ammo: " + CS_Score.z;
            }
            else
            {
                CS_Score.Mag.text = "Mag: " + "Empty";
                CS_Score.Ammo.text = "Ammo: " + "Out Of Ammo";
            }
            if (CS_Score.x >= 25)
            {
                if (!Ability1)
                {
                    abilityCharge++;
                    Ability1 = true;
                }
            }
            if (CS_Score.x >= 50)
            {
                if (!Ability2)
                {
                    abilityCharge++;
                    Ability2 = true;
                }
            }
            if (CS_Score.x >= 75)
            {
                if (!Ability3)
                {
                    abilityCharge++;
                    Ability3 = true;
                }
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
            if (chargerCount < 0) return true;
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
            if (currentCount >= shellCount)
            {
                chargerCount--;
                currentCount = 0;
            }
        }

        public bool MalletIntAbility()
        {
            if (abilityCharge < 0) return true;
            if (abilityCharge > 0)
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

        IEnumerator FireWeapon()
        {
            while (true)
            {
                // Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2, Screen.height / 2, 0));
                // if (Physics.Raycast(ray, out hitInfo))
                // {
                //     targetPoint = hitInfo.point;
                // }
                // else
                // {

                //     targetPoint = Camera.main.transform.forward * 1000;
                // }

                Instantiate(Bullet, Bullet_Position.transform.position, Bullet_Position.transform.rotation); //.transform.LookAt(targetPoint)
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
                abilityCharge--;
                // AudioSource.PlayClipAtPoint(Ability, transform.localPosition);
                yield return new WaitForSeconds(MalletInt);
            }
        }
    }
}
