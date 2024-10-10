using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Myfps
{
    public class AOpening : MonoBehaviour
    {
        #region Variables
        public SceneFader sceneFader;
        public GameObject thePlayer;

        //UI
        public TextMeshProUGUI sceneText;
        [SerializeField] private string sequence = "I need get out of here";
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(OpeningFader());
        }
        IEnumerator OpeningFader()
        {
            //플레이 캐릭터 비 활성화
            thePlayer.SetActive(false);
            //페이드인 연출 (1초 대기후 페인드인 효과)
            sceneFader.FromFade(1);
            //화면 하단에 시나리오 텍스트 화면 출력(3초) (I need get out of here)
            sceneText.enabled = true;
            sceneText.text = sequence;
            yield return new WaitForSeconds(3);
            //3초후에 시나리오 텍스트 없어진다
            sceneText.text = "";
            //플레이 캐릭터 활성화
            thePlayer.SetActive(true);
        }
    }
}
