using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

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
            if (theDistance <= 2)
            {
                ActionUI();
                if (Input.GetKey(KeyCode.E))
                {
                    //Debug.Log("Open the Door");
                    Door.SetBool("IsOpen", true);
                    Audio.Play();
                    actionText.text = "Close the Door";
                    keyText.text = "[R]";
                }
                else if (Input.GetKey(KeyCode.R))
                {
                    //close the Door
                    Door.SetBool("IsOpen", false);
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
            actionText.text = "Open the Door";
        }
        //마우스가 벗어나면 액션 UI를 감춘다
        private void OnMouseExit()
        {
            HideActionUI();
        }
        void HideActionUI()
        {
            actinUI.SetActive(false);
            actionText.text = "";
            extraCross.SetActive(false);
        }
    }
}