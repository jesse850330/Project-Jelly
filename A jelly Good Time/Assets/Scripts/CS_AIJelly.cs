using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Random = UnityEngine.Random;

namespace ProjectJelly.FPP
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class CS_AIJelly : MonoBehaviour
    {
        NavMeshAgent m_Agent;
        private GameObject target;


        void Start()
        {
            m_Agent = GetComponent<NavMeshAgent>();

            GameObject[] targets = GameObject.FindGameObjectsWithTag("Crop");
            GameObject ramdomTarget = targets [Random.Range(0, targets.Length)];
            target = ramdomTarget;
            
        }

        void Update()
        {
            m_Agent.destination = target.transform.position; 
        }

    }

}