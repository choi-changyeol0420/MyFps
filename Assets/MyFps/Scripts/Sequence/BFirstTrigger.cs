using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Myfps
{
    public class BFirstTrigger : MonoBehaviour
    {
        #region Variables
        public GameObject thePlayer;
        public TextMeshProUGUI sceneText;
        private string lineText = "Looks like a weapon on that table.";
        public GameObject Arrow;
        #endregion
        private void OnTriggerEnter(Collider other)
        {
            StartCoroutine(FirstTrigger());
        }
        //트리거 작동시 플레이
        IEnumerator FirstTrigger()
        {
            //플레이 캐릭터 비활성화  (플레이 멈춤)
            thePlayer.SetActive(false);

            //대사 출력 :  "Looks like a weapon on that table."
            sceneText.text = lineText;

            //1초 딜레이
            yield return new WaitForSeconds(1);

            //화살표 활성화
            Arrow.SetActive(true);

            //1초 딜레이
            yield return new WaitForSeconds(1);

            //초기화
            sceneText.text = "";
            sceneText.gameObject.SetActive(false);

            //플레이 캐릭터 활성화 (다시 플레이)
            thePlayer.SetActive(true);
            transform.GetComponent<BoxCollider>().enabled = false;
        }
    }
}