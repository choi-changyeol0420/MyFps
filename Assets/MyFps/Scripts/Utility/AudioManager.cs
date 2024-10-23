using Unity.VisualScripting;
using UnityEngine;

namespace Myfps
{
    //오디오를 관리하는 클래스
    public class AudioManager : PersistentSingleton<AudioManager>
    {
        #region Variables
        public Sound[] sounds;

        private string bgmSound = "";   //현재 플레이 되는 이름
        public string BgmSound   
        {
            get {return bgmSound;}
        }
        #endregion
        protected override void Awake()
        {
            //Singletone 구현부
            base.Awake();

            //AudioManager 초기화
            foreach (var sound in sounds)
            {
                sound.Source = this.gameObject.AddComponent<AudioSource>();

                sound.Source.clip = sound.clip;
                sound.Source.volume = sound.volume;
                sound.Source.pitch = sound.pitch;
                sound.Source.loop = sound.loop;
            }
        }
        public void Play(string name)
        {
            Sound sound = null;
            //매개변수로 이름과 같은 클립 찾기
            foreach (var s in sounds)
            {
                if (s.name == name)
                {
                    sound = s;
                    break;
                }
            }
            if (sound == null)
            {
                Debug.Log($"cilp Find: {name}");
                return;
            }
            sound.Source.Play();
        }

        public void Stop(string name)
        {
            Sound sound = null;
            //매개변수로 이름과 같은 클립 찾기
            foreach (var s in sounds)
            {
                if (s.name == name)
                {
                    sound = s;

                    if(s.name == bgmSound)
                    {
                        bgmSound = "";
                    }
                    break;
                }
            }
            if (sound == null)
            {
                Debug.Log($"cilp Find: {name}");
                return;
            }
            sound.Source.Stop();
        }
        public void PlayBgm(string name)
        {
            //배경음 이름 체크
            if(name == bgmSound)
            {
                return;
            }
            //배경음 정지
            StopBgm();

            Sound sound = null;
            //매개변수로 이름과 같은 클립 찾기
            foreach (var s in sounds)
            {
                if (s.name == name)
                {
                    bgmSound = s.name;
                    sound = s;
                    break;
                }
            }
            if(sound == null)
            {
                Debug.Log($"cilp Find: {name}");
                return;
            }
            sound.Source.Play();
        }
        public void StopBgm()
        {
            Stop(bgmSound);
        }
    }
}