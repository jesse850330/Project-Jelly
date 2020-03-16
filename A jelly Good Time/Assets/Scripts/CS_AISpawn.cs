using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_AISpawn : MonoBehaviour
    {
        public GameObject[] Enemys;
        public Transform[] Points;
        public float level1;
        public float level2;
        public float level3;
        public float CoolInt;
        public float WaitInt;
        public static float kill;
        public float killed;
        public float SpawnCount;
        private bool lvl1 = false;
        private bool lvl2 = false;
        private bool lvl3 = false;
        private bool lv1 = false;
        private bool lv2 = false;
        private bool lv3 = false;

        void Start()
        {
            StartCoroutine(StartSpawn());
        }

        void Update()
        {
            killed = kill;
            if (SpawnCount == level1)
            {
                if (!lvl1)
                {
                    lvl1 = true;
                    Debug.Log("Level 1 Spawn Done");
                    StopAllCoroutines();
                }
            }
            if (SpawnCount == level2)
            {
                if (!lvl2)
                {
                    lvl2 = true;
                    Debug.Log("Level 2 Spawn Done");
                    StopAllCoroutines();
                }
            }
            if (SpawnCount == level3)
            {
                if (!lvl3)
                {
                    lvl3 = true;
                    Debug.Log("Level 3 Spawn Done");
                    StopAllCoroutines();
                }
            }
            if (killed == level1)
            {
                if (!lv1)
                {
                    SpawnCount = 0;
                    Debug.Log("Level 1 Clear");
                    StopAllCoroutines();
                    Invoke("changelevel", CoolInt);
                    lv1 = true;
                }


            }
            if (killed == level1 + level2)
            {
                if (!lv2)
                {
                    SpawnCount = 0;
                    Debug.Log("Level 2 Clear");
                    StopAllCoroutines();
                    Invoke("changelevel", CoolInt);
                    lv2 = true;
                }
            }
            if (killed == level1 + level2 + level3)
            {
                if (!lv3)
                {
                    SpawnCount = 0;
                    StopAllCoroutines();
                    Debug.Log("Level 3 Clear");
                    lv3 = true;
                }
            }

        }

        void changelevel()
        {
            StartCoroutine(StartSpawn());
        }

        IEnumerator StartSpawn()
        {
            while (true)
            {
                int Random_Objects = Random.Range(0, Enemys.Length);
                int Random_Points = Random.Range(0, Points.Length);
                Instantiate(Enemys[Random_Objects], Points[Random_Points].transform.position, Points[Random_Points].transform.rotation);
                SpawnCount++;
                yield return new WaitForSeconds(WaitInt);
            }
        }




    }
}