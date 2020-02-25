using UnityEngine;
using UnityEngine.AI;
using System.Collections;

namespace ProjectJelly.FPP
{
    public class CS_AIAttack : MonoBehaviour
    {
        public const int maxHealth = 100;
        public int currentHealth = maxHealth;
        public void TakeDamage(int amount)
        {
            currentHealth -= amount;
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                Destroy(gameObject);
            }
        }
        void OnTriggerEnter(Collider basic)
        {
            currentHealth -= 5;
        }

    }
}