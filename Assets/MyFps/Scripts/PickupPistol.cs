using TMPro;
using UnityEngine;

namespace Myfps
{
    public class PickupPistol : Interactive
    {
        #region Variables
        public GameObject realPistol;
        public GameObject Arrow;
        public GameObject enemyTrigger;
        #endregion
        protected override void DoAction()
        {
            keyText.text = "[E]";
            actionText.text = "Pick Up Pistol";
            if (Input.GetKeyDown(KeyCode.E))
            {
                realPistol.SetActive(true);
                Arrow.SetActive(false);
                enemyTrigger.SetActive(true);
                Destroy(gameObject);
                HideActionUI();
            }
        }
        
    }
}