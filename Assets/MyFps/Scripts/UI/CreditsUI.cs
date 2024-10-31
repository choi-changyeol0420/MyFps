using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    public class CreditsUI : MonoBehaviour
    {
        #region Variables
        public GameObject mainMenu;
        #endregion
        private void Update()
        {
            if(Input.GetKeyUp(KeyCode.Escape))
            {
                this.gameObject.SetActive(false);
                mainMenu.SetActive(true);
            }
        }
    }
}