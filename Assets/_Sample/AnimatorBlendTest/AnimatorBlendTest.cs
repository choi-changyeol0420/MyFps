using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sample
{
    public class AnimatorBlendTest : MonoBehaviour
    {
        #region Variables
        //이동
        [SerializeField] private float movespeed = 5f;

        //입력값
        private float moveX;
        private float moveY;

        //애니메이터
        private Animator animator;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            animator = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            //입력 처리
            moveX = Input.GetAxis("Horizontal");
            moveY = Input.GetAxis("Vertical");

            //이동: 방향, 속도
            Vector3 dir = new Vector3(moveX,0f, moveY);
            transform.Translate(dir.normalized * movespeed* Time.deltaTime,Space.World);

            //AnimationStateTest();
            AnimationBlendTest();
        }
        void AnimationBlendTest()
        {
            animator.SetFloat("MoveX", moveX);
            animator.SetFloat("MoveY", moveY);

        }
        void AnimationStateTest()
        {
            if (moveY > 0f)
            {
                animator.SetInteger("MoveState", 1);    //앞
            }
            if (moveY < 0f)
            {
                animator.SetInteger("MoveState", 2);    //뒤
            }
            if (moveX < 0f)
            {
                animator.SetInteger("MoveState", 3);    //좌
            }
            if (moveX > 0f)
            {
                animator.SetInteger("MoveState", 4);     //우
            }
            if(moveX ==  0f && moveY == 0f)
            {
                animator.SetInteger("MoveState", 0);    //대기
            }
        }
        
    }
}