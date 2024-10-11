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
        #endregion

        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(FirstTrigger());
        }
        //트리거 작동시 플레이
        IEnumerator FirstTrigger()
        {
            theDoor.GetComponent<Animator>().SetBool("IsOpen", true);
            theDoor.GetComponent<BoxCollider>().enabled = false;
            yield return null;
        }
    }
}