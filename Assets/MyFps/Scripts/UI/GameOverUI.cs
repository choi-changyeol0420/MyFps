using UnityEngine;
using UnityEngine.SceneManagement;

namespace Myfps
{
    public class GameOverUI : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField]private string loadtoScene = "MainMenu";
        #endregion
        private void Start()
        {
            //마우스 커서 상태 설정
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            //페이드인 효과
            fader.FromFade();
        }
        public void Retry()
        {
            if(PlayerState.Instance.SceneNumber == 3)
            {
                fader.FadeTo(3);
            }
            else if(PlayerState.Instance.SceneNumber == 4)
            {
                fader.FadeTo(4);
            }
        }
        public void Menu()
        {
            fader.FadeTo(loadtoScene);
        }

    }
}