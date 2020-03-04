using UnityEngine;
using UnityEngine.AI;
using System.Collections;

namespace ProjectJelly.FPP
{
    public class CS_AIAttack : CS_HPControl
    {
        Animator anim;
        CS_Crops target;
        public int view;
        Rigidbody rigid;
        public EnemyState state;
        Transform eye;
        public override void Init()
        {
            base.Init();
            anim = GetComponent<Animator>();
            rigid = GetComponent<Rigidbody>();
            gameObject.layer = LayerMask.NameToLayer("Enemy");
            state = EnemyState.forward;
            eye = transform.Find("Eye");
        }

        private void Update()
        {
            if (CS_GameMain.instance.gameOver)
                anim.Play("idle");
            else if (state == EnemyState.forward)
                EnemyForward();
        }

        private void EnemyForward()
        {
            RaycastHit hit;
            if (Physics.Raycast(eye.position, transform.forward, out hit, view, LayerMask.GetMask("Crop")))
            {
                state = EnemyState.attack;
                anim.Play("attack");
                target = hit.collider.GetComponent<CS_Crops>();
            }
        }

        public enum EnemyState
        {
            forward,
            attack,
            death
        }

    }

}