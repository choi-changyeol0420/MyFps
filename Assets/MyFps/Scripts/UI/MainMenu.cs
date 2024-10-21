using UnityEngine;

namespace Myfps
{
    public class MainMenu : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField] private string loadtoScene = "MainScene01";
        #endregion
        private void Start()
        {
            fader.FromFade();
        }
        public void NewGame()
        {
            fader.FadeTo(loadtoScene);
        }
        public void LoadGame()
        {
            Debug.Log("Goto LoadGame");
        }
        public void Options()
        {
            Debug.Log("Show Options");
        }
        public void Credits()
        {
            Debug.Log("Show Credits");
        }
        public void QuitGame()
        {
            Debug.Log("Quit Game");
            Application.Quit();
        }
    }
}