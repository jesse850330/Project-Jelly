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
        private GameObject target = null;

        float pathTime = 0f;
        int slot = -1;


        void Start()
        {
            m_Agent = GetComponent<NavMeshAgent>();

            GameObject[] targets = GameObject.FindGameObjectsWithTag("Crop");
            GameObject ramdomTarget = targets[Random.Range(0, targets.Length)];
            target = ramdomTarget;

        }

        void Update()
        {
            pathTime += Time.deltaTime;
            if (pathTime > 0.5f)
            {
                pathTime = 0f;
                var slotManager = target.GetComponent<CS_SlotManager>();
                if (slotManager != null)
                {
                    if (slot == -1)
                        slot = slotManager.Reserve(gameObject);
                    if (slot == -1)
                        return;
                    var agent = GetComponent<NavMeshAgent>();
                    if (agent == null)
                        return;
                    agent.destination = slotManager.GetSlotPosition(slot);
                }
            }
        }

    }

}
