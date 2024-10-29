using Myfps;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    public class EnemyTest : MonoBehaviour, IDamageable
    {
        #region Variables
        //체력
        [SerializeField] private float maxhealth = 20;
        private float currenthealth;

        private bool isDeath;
        #endregion
        private void Start()
        {
            //초기화
            currenthealth = maxhealth;
            isDeath = false;
        }
        public void TakeDamage(float damage)
        {
            currenthealth -= damage;
            Debug.Log($"Enemy 체력은 {currenthealth}");

            //데미지 효과

            if(currenthealth <= 0 && !isDeath)
            {
                Die();
            }
        }
        private void Die()
        {
            isDeath = true;
            //죽음 처리
            //보상 - 경험치,돈,아이템
            //효과
            Destroy(gameObject,3f);

        }
    }
}