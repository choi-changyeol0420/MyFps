using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Myfps
{
    public class CEnemytrigger : MonoBehaviour
    {
        #region Variables
        public GameObject theDoor;
        public AudioSource doorBang;
        public AudioSource jumpsource;
        public GameObject theEnemy;
        #endregion
        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(FirstTrigger());
        }
        //트리거 작동시 플레이
        IEnumerator FirstTrigger()
        {
            //문 열기 애니메이션
            theDoor.GetComponent<Animator>().SetBool("IsOpen", true);
            theDoor.GetComponent<BoxCollider>().enabled = false;
            //문 사운드
            doorBang.Play();
            //Enemy 활성화
            theEnemy.SetActive(true);

            yield return new WaitForSeconds(1f);

            //Enemy 등장 사운드
            jumpsource.Play();
            EnemyController enemy = theEnemy.GetComponent<EnemyController>();
            if (enemy != null)
            {
                enemy.SetState(EnemyState.E_Walk);
            }
            Destroy(this.gameObject);
        }
    }
}