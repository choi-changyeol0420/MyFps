using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace Myfps
{
    public class MainMenu : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField] private string loadtoScene = "MainScene01";
        private string soundButton = "MenuButton";

        private AudioManager audioManager;
        public GameObject mainmenuUI;
        public GameObject optionsUI;
        public GameObject CreditsUI;

        //Audio
        public AudioMixer mixer;

        public Slider bgmSlider;
        public Slider sfxSlider;
        #endregion
        private void Start()
        {
            //게임 저장데이터, 저장된 옵션값 불러오기
            LoadOption();

            //씬 페이더 효과
            fader.FromFade();

            //참조
            audioManager = AudioManager.Instance;

            //배경음
            audioManager.PlayBgm("MenuBGM");
        }
        public void NewGame()
        {
            audioManager.Play(soundButton);
            fader.FadeTo(loadtoScene);
        }
        public void LoadGame()
        {
            audioManager.Play(soundButton);
            Debug.Log("Goto LoadGame");
        }
        public void Options()
        {
            audioManager.Play(soundButton);
            ShowOption();
        }
        public void Credits()
        {
            audioManager.Play(soundButton);
            Debug.Log("Show Credits");
            ShowCredits();
        }
        public void QuitGame()
        {
            //Cheating
            PlayerPrefs.DeleteAll();

            audioManager.Play(soundButton);
            Debug.Log("Quit Game");
            Application.Quit();
        }
        private void ShowOption()
        {
            mainmenuUI.SetActive(false);
            optionsUI.SetActive(true);
        }
        public void HideOption()
        {
            //
            SaveOption();

            audioManager.Play(soundButton);
            mainmenuUI.SetActive(true);
            optionsUI.SetActive(false);
        }
        public void SetBGMVolume(float value)
        {
            mixer.SetFloat("BGM", value);
        }
        public void SetSFXVolume(float value)
        {
            mixer.SetFloat("SFX", value);
        }
        //옵션값 저장
        private void SaveOption()
        {
            PlayerPrefs.SetFloat("BGM", bgmSlider.value);
            PlayerPrefs.SetFloat("SFX", sfxSlider.value);
        }
        //옵션값 로드하기
        private void LoadOption()
        {
            //배경음 볼륨
            float bgmVolume = PlayerPrefs.GetFloat("BGM", 0);
            SetBGMVolume(bgmVolume);        //사운드 볼륨 조절
            bgmSlider.value = bgmVolume;    //UI 셋팅

            //효과음 볼륨
            float sfxVolume = PlayerPrefs.GetFloat("SFX", 0);
            SetSFXVolume(sfxVolume);
            sfxSlider.value = sfxVolume;
        }
        private void ShowCredits()
        {
            mainmenuUI.SetActive(false );
            CreditsUI.SetActive(true);
        }
    }
}