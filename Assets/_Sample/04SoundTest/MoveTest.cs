using UnityEngine;

namespace MySample
{
    public class MoveTest : MonoBehaviour
    {
        #region Variables
        [SerializeField]private float movespeed = 5;
        [SerializeField]private float forwardForce = 2;
        private Rigidbody rb;
        private float dx;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            //좌우 이동
            dx = Input.GetAxis("Horizontal");
        }
        private void FixedUpdate()
        {
            rb.AddForce(0f, 0f, forwardForce, ForceMode.Acceleration);
            if(dx < 0f)
            {
                rb.AddForce(-movespeed, 0f,0f, ForceMode.Acceleration);
            }
            if (dx > 0f)
            {
                rb.AddForce(movespeed, 0f,0f, ForceMode.Acceleration);
            }
        }
    }
}