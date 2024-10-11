using TMPro;
using UnityEngine;

namespace Myfps
{
    //인터렉티브를 액션을 구현하는 클래스
    public abstract class Interactive : MonoBehaviour
    {
        protected abstract void DoAction();

        #region Variables
        //actionUI
        public GameObject actinUI;
        public TextMeshProUGUI actionText;
        public TextMeshProUGUI keyText;
        public GameObject extraCross;

        private float theDistance;

        #endregion

        private void Update()
        {
            theDistance = PlayerCasting.distanceFromTarget;
        }
        private void OnMouseOver()
        {
            if (theDistance <= 2)   //Player와총 사이에 거리
            {
                ActionUI();
                DoAction();
            }
            else
            {
                HideActionUI();
            }
        }
        void ActionUI()
        {
            actinUI.SetActive(true);
            extraCross.SetActive(true);
        }
        private void OnMouseExit()
        {
            HideActionUI();
        }
        protected void HideActionUI()
        {
            actinUI.SetActive(false);
            extraCross.SetActive(false);
        }
    }
}