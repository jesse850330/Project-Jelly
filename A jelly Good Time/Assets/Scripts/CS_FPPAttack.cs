using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectJelly.FPP
{
    public class CS_FPPAttack : CS_HPControl
    {
        Animator anim;
        public float damage;
        CS_Crops target;
        public override void Init()
        {
            base.Init();
            anim = GetComponent<Animator>();
        }

        private void EnemyAttack()
        {
            if (target != null)
            target.Damage(damage);
        }
        public override void Death()
        {
            base.Death();
            anim.Play("death");
        }
        private void DestorySelf()
        {
            Destroy(gameObject);
        }
    }
}