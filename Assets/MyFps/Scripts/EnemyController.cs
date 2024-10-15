using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    //로봇 상태
    public enum EnemyState
    {
        E_Idle,
        E_Walk,
        E_Attack,
        E_Death
    }

    //로봇Enemy 관리 클래스
    public class EnemyController : MonoBehaviour
    {
        #region Variables
        public Animator animator;

        //로봇 현재 상태
        private EnemyState enemyState;

        private EnemyState beforeState;

        //private float movespeed = 0.5f;
        //체력
        private float health;
        private float starthealth = 20;
        #endregion
        private void Start()
        {
            //초기화
            starthealth = health;
            //참조
            animator = GetComponent<Animator>();
            SetState(EnemyState.E_Idle);
        }
        void EnemyWalk()
        {
            SetState(EnemyState.E_Walk);
        }
        void AttackPlayer()
        {
            SetState(EnemyState.E_Attack);
        }
        void Die()
        {
            SetState(EnemyState.E_Death);
            Destroy(gameObject,5f);
        }
        public void TakeDamage(float damage)
        {
            health -= damage;
            if (health <= 0)
            {
                Die();
            }
        }
        //로봇Enemy 상태 변경
        private void SetState(EnemyState Enemystate)
        {
            //현재 상태 체크
            if (enemyState == Enemystate)
                return;
            //이전 상태 저장
            beforeState = enemyState;
            //상태 변경
            enemyState = Enemystate;
            //상태 변경에 따른 구현 내용
            animator.SetInteger("EnemyState", (int)Enemystate);
        }
    }
    
}