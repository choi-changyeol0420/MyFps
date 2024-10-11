using TMPro;
using UnityEngine;

namespace Myfps
{
    public class PickupPistol : Interactive
    {
        #region Variables
        public GameObject realPistol;
        public GameObject Arrow;
        #endregion
        protected override void DoAction()
        {
            keyText.text = "[E]";
            actionText.text = "Pick Up Pistol";
            if (Input.GetKeyDown(KeyCode.E))
            {
                realPistol.SetActive(true);
                Arrow.SetActive(false);
                Destroy(gameObject);
                HideActionUI();
            }
        }
        
    }
}