using UnityEngine;

namespace MySample
{
    public class MoveWall : MonoBehaviour
    {
        #region Variables
        [SerializeField]private float movespeed = 1f;

        [SerializeField]private float movetime = 1f;
        private float countdown = 0f;

        //이동방향 좌/우
        [SerializeField] private float dir = 1f;
        #endregion

        private void Start()
        {
            //초기화
            countdown = movetime;
        }

        private void Update()
        {
            //좌우 이동 타이머
            if(countdown <= 0)
            {
                //타이머 액션 - 방향전환
                dir *= -1;
                //초기화
                countdown = movetime;
            }
            countdown -= Time.deltaTime;

            transform.Translate(Vector3.right * dir * movespeed * Time.deltaTime,Space.World);
        }
    }
}