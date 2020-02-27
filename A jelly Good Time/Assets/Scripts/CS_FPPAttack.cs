using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_FPPAttack : CS_HPControl
    {
        Animator anim;
        public float damage;
        Main target;

        private void EnemyAttack()
        {
            if (target != null)
            target.Damage(damage);
        }
    }
}