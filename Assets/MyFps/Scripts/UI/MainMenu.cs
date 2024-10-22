using UnityEngine;

namespace Myfps
{
    public class MainMenu : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField] private string loadtoScene = "MainScene01";
        private string soundButton = "MenuButton";

        private AudioManager audioManager;
        #endregion
        private void Start()
        {
            fader.FromFade();

            //참조
            audioManager = AudioManager.Instance;

            audioManager.PlayBgm("MenuBGM");
        }
        public void NewGame()
        {
            audioManager.Stop(audioManager.BgmSound);
            audioManager.Play(soundButton);
            fader.FadeTo(loadtoScene);
        }
        public void LoadGame()
        {
            audioManager.Stop(audioManager.BgmSound);
            audioManager.Play(soundButton);
            Debug.Log("Goto LoadGame");
        }
        public void Options()
        {
            audioManager.Stop(audioManager.BgmSound);
            audioManager.Play(soundButton);
            audioManager.PlayBgm("PlayBGM");
            Debug.Log("Show Options");
        }
        public void Credits()
        {
            audioManager.Stop(audioManager.BgmSound);
            audioManager.Play(soundButton);
            Debug.Log("Show Credits");
        }
        public void QuitGame()
        {
            audioManager.Stop(audioManager.BgmSound);
            audioManager.Play(soundButton);
            Debug.Log("Quit Game");
            Application.Quit();
        }
    }
}