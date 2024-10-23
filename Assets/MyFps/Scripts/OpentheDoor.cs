using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    public class OpentheDoor : Interactive
    {
        public PickupKey key;
        private Animator animator;
        private Collider m_collider;

        private void Start()
        {
            animator = GetComponent<Animator>();
            m_collider = GetComponent<BoxCollider>();
        }
        protected override void DoAction()
        {
            keyText.text = "[E]";
            actionText.text = "Open the Door";
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (!key.isKey)
                {
                    AudioManager.Instance.Play("DoorLocked");
                    return;
                }
                if (key.isKey)
                {
                    animator.SetBool("IsOpen", true);
                    AudioManager.Instance.Play("DoorBang");
                    keyText.text = "";
                    actionText.text = "";
                    m_collider.enabled = false;
                }
            }
        }
    }
}