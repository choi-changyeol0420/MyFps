using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Myfps
{
    public class PauseUI : MonoBehaviour
    {
        private GameObject theplayer;
        public GameObject pauseUI;
        //public SceneFader fader;
        [SerializeField] private string lodetoname = "GotoMenu";
        private void Start()
        {
            theplayer = GameObject.Find("Player");
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                Continue();
            }
        }
        public void Continue()
        {
            pauseUI.SetActive(!pauseUI.activeSelf);

            if (pauseUI.activeSelf)
            {
                Time.timeScale = 0f;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                theplayer.SetActive(false);     
            }
            else
            {
                Time.timeScale = 1f;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                theplayer.SetActive(true); 
            }
        }
        public void MainMenu()
        {
            Time.timeScale = 1f;
            Debug.Log(lodetoname);
        }
    }
}