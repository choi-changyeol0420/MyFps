using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

namespace Myfps
{
    public class TorchLight : MonoBehaviour
    {
        #region Variables
        public Transform torchLight;
        private Animator animator;
        private int lightMode;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            animator = torchLight.GetComponent<Animator>();
            lightMode = 0;

            InvokeRepeating("LightAnimation", 0f, 1f);
        }

        // Update is called once per frame
        void Update()
        {
            //1초마다 1번씩 랜덤한 라이트 애니메이션을 플레이
            /*if (lightMode == 0)
            {
                StartCoroutine(FlameAnimation());
            }*/
        }
        IEnumerator FlameAnimation()        //코루틴을 이용한 랜덤 애니메이션
        {
            lightMode = Random.Range(1, 4);
            switch (lightMode)
            {
                case 1:
                    animator.SetInteger("LightMode", lightMode);
                    break;
                case 2:
                    animator.SetInteger("LightMode", lightMode);
                    break;
                case 3:
                    animator.SetInteger("LightMode", lightMode);
                    break;
            }

            yield return new WaitForSeconds(1.0f);
            lightMode = 0;
        }

        private void LightAnimation()
        {
            lightMode = Random.Range(1, 4);
            animator.SetInteger("LightMode", lightMode);
        }
    }
}