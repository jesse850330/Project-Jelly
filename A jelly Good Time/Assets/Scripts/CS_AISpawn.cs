using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;



namespace ProjectJelly.FPP
{
    public class CS_AISpawn : MonoBehaviour
    {
        public GameObject[] Enemys;
        public Transform[] Points;
        public int SpawnCount;
        public float Ins_Time;
        public float level1;
        public float level2;
        public float level3;
        public float levelInt;
        public static float kill;
        public float killed;
        private bool lv1 = false;
        private bool lv2 = false;
        private bool lv3 = false;

        void Start()
        {
            InvokeRepeating("Ins_Objs", Ins_Time, Ins_Time);
        }

        void Update()
        {
            killed = kill;
            if (SpawnCount == level1)
            {
                StopSpawn();
            }
            if (SpawnCount == level2)
            {
                StopSpawn();
            }
            if (SpawnCount == level3)
            {
                StopSpawn();
            }
            if (killed == level1)
            {
                nextlevel();
            }
        }

        void Ins_Objs()
        {
            int Random_Objects = Random.Range(0, Enemys.Length);
            int Random_Points = Random.Range(0, Points.Length);
            Instantiate(Enemys[Random_Objects], Points[Random_Points].transform.position, Points[Random_Points].transform.rotation);
            SpawnCount++;
        }

        void StartSpawn()
        {
            InvokeRepeating("Ins_Objs", Ins_Time, Ins_Time);
        }

        void StopSpawn()
        {
            CancelInvoke("Ins_Objs");
        }
        void changelevel2()
        {
            if (!lv1)
            {
                lv1 = true;
            }
        }
        void nextlevel()
        {
            SpawnCount = 0;
            CoolDown();
        }
        IEnumerator CoolDown()
        {
            yield return new WaitForSeconds(levelInt);
        }

    }
}