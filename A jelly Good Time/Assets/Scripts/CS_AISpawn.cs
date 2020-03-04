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

        public float Ins_Time = 1;



        void Start()

        {

            InvokeRepeating("Ins_Objs", Ins_Time, Ins_Time);

        }



        void Ins_Objs() //生成物件函式。

        {

            int Random_Objects = Random.Range(0, Enemys.Length);

            int Random_Points = Random.Range(0, Points.Length);

            Instantiate(Enemys[Random_Objects], Points[Random_Points].transform.position, Points[Random_Points].transform.rotation);

        }

    }
}