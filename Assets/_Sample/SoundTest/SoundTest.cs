using UnityEngine;

namespace MySample
{
    public class SoundTest : MonoBehaviour
    {
        #region Variables
        private AudioSource source;

        public AudioClip clip;

        [SerializeField] private float volume = 1.0f;
        [SerializeField] private float pitch = 1.0f;
        [SerializeField] private bool loop = false;
        //[SerializeField] private bool playOnAwake = false;
        #endregion
        // Update is called once per frame
        void Start()
        {
            source = GetComponent<AudioSource>();
            SoundPlay();
            SoundOneShot();
        }
        void SoundPlay()
        {
            source.clip = clip;
            source.volume = volume;
            source.pitch = pitch;
            source.loop = loop;
            //source.playOnAwake = playOnAwake;
            source.Play();
        }
        void SoundOneShot()
        {
            source.PlayOneShot(clip,volume);
        }
    }
}