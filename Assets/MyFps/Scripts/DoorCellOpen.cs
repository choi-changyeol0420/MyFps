using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Myfps
{
    public class DoorCellOpen : MonoBehaviour
    {
        #region Variables
        public GameObject actinUI;
        public TextMeshProUGUI actionText;
        public TextMeshProUGUI keyText;
        public GameObject extraCross;

        private float theDistance;
        private Animator Door;
        private Collider m_collider;
        public AudioSource Audio;
        #endregion
        private void Start()
        {
            Door = GetComponent<Animator>();
            m_collider = GetComponent<BoxCollider>();
        }
        private void Update()
        {
            theDistance = PlayerCasting.distanceFromTarget;
        }
        //마우스를 가져가면 액션 UI를 보여준다
        private void OnMouseOver()
        {
            if (theDistance <= 2)   //Player와문 사이에 거리
            {
                ActionUI();
                if (Input.GetKey(KeyCode.E))    //여는 키
                {
                    //Debug.Log("Open the Door");
                    Door.SetBool("IsOpen", true);
                    Audio.Play();
                    //닫을 때에 텍스트
                    keyText.text = "[R]";
                    actionText.text = "Close the Door";
                }
                else if (Input.GetKey(KeyCode.R))   //닫는 키
                {
                    //close the Door
                    Door.SetBool("IsOpen", false);
                    Audio.Play();
                    //열 때에 텍스트
                    keyText.text = "[E]";
                    actionText.text = "Open the Door";

                }
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
        //마우스가 벗어나면 액션 UI를 감춘다
        private void OnMouseExit()
        {
            HideActionUI();
        }
        void HideActionUI()
        {
            actinUI.SetActive(false);
            extraCross.SetActive(false);
        }
    }
}