using UnityEngine;
using UnityEngine.AI;
using System.Collections;

namespace ProjectJelly.FPP
{
    public class CS_AIMove : MonoBehaviour
    {
        public Transform goal;

        void Start()
        {
            NavMeshAgent agent = GetComponent<NavMeshAgent>();
            agent.destination = goal.position;
        }
    }
}