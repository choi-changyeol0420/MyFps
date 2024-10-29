using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    public class GEnemyZoneTrigger : MonoBehaviour
    {
        #region Variables
        public Transform gunMan;

        #endregion
        private void OnTriggerEnter(Collider other)
        {
            //건맨이 추격시작
            if(other.tag == "Player")
            {
                gunMan.GetComponent<Enemy>().SetState(RobotState.E_Chase);
                //
            }
        }
    }
}