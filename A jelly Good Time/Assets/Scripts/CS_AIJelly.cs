using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace ProjectJelly.FPP
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class CS_AIJelly : MonoBehaviour
    {
        public Transform goal;
        NavMeshAgent m_Agent;

        void Start()
        {
            m_Agent = GetComponent<NavMeshAgent>();
        }

        void Update()
        {
            m_Agent.destination = goal.position; 
        }

    }

}