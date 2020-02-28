using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_HPControl : MonoBehaviour
    {
        public float totalHP = 100;
        float surHP;
        public virtual void Init()
        {
            surHP = totalHP;
        }

        public void Damage (float damage)
        {
            if (surHP > damage)
            {
                surHP -= damage;
            }
            else
            {
                Death();
            }
        }
        public virtual void Death()
        {
            surHP = 0;
        }
    }
}