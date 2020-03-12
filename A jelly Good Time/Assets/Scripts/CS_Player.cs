using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_Player : MonoBehaviour
    {
        public float BulletInt;
        public float ReloadInt;
        public float MalletInt;
        public int shellCount = 50;
        public int currentCount;
        public int usedCount;
        private float currentFireTime;
        public float loadTime = 1.5f;//Reload
        private float currentLoadTime = 0;
        public int chargerCount = 250;
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
        private bool Ability1 = false;
        private bool Ability2 = false;
        private bool Ability3 = false;
        private bool Ability4 = false;
        private bool Ability5 = false;


        void Update()
        {
            CS_Score.c = abilityCharge;
            CS_Score.y = chargerCount;
            CS_Score.z = shellCount - currentCount;
            CS_Score.AbilityM.text = "Ability: " + CS_Score.c;
            CS_Score.Mag.text = "/ " + CS_Score.y;
            CS_Score.Ammo.text = "Ammo: " + CS_Score.z;
            if (!isLoading() && Input.GetKeyDown(KeyCode.Mouse0))
            {
                StartCoroutine(FireWeapon());
            }
            if (Input.GetKeyUp(KeyCode.Mouse0))
            {
                StopAllCoroutines();
            }
            else if (currentCount == shellCount || shellCount == 0)
            {
                StopAllCoroutines();
            }
            if (Input.GetKey(KeyCode.R))
            {
                StartCoroutine(reLoading());
            }
            if (!MalletIntAbility() && Input.GetKeyDown(KeyCode.Mouse1))
            {
                StartCoroutine(MalletAbility());
            }
            if (Input.GetKeyUp(KeyCode.Mouse1))
            {
                StopAllCoroutines();
            }
            if (CS_Score.x >= 100)
            {
                if (!Ability1)
                {
                    abilityCharge++;
                    Ability1 = true;
                }
            }
            if (CS_Score.x >= 200)
            {
                if (!Ability2)
                {
                    abilityCharge++;
                    Ability2 = true;
                }
            }
            if (CS_Score.x >= 300)
            {
                if (!Ability3)
                {
                    abilityCharge++;
                    Ability3 = true;
                }
            }
            if (CS_Score.x >= 400)
            {
                if (!Ability4)
                {
                    abilityCharge++;
                    Ability4 = true;
                }
            }
            if (CS_Score.x >= 500)
            {
                if (!Ability5)
                {
                    abilityCharge++;
                    Ability5 = true;
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
            if (shellCount < 0) return true;
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

        public void reLoad()
        {
            if (chargerCount > shellCount)
            {
                usedCount = chargerCount - currentCount;
                chargerCount = usedCount;
                currentCount = 0;
            }
            else if (chargerCount < currentCount)
            {
                shellCount = shellCount + (chargerCount - currentCount);
                chargerCount = 0;
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
                Instantiate(Bullet, Bullet_Position.transform.position, Bullet_Position.transform.rotation);
                currentCount++;
                // AudioSource.PlayClipAtPoint(Fire, transform.localPosition);
                yield return new WaitForSeconds(BulletInt);
            }
        }
        IEnumerator reLoading()
        {
            yield return new WaitForSeconds(ReloadInt);
            reLoad();
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
