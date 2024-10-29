using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    public class MoveObject : MonoBehaviour
    {
        #region Variables
        private Rigidbody rb;

        //좌우로 힘을 주어 이동
        [SerializeField]private float movepower = 5f;
        private float moveX;
        private Material Material;
        private Color origincolor;
        #endregion
        // Start is called before the first frame update
        void Start()
        {
            //참조
            rb = GetComponent<Rigidbody>();
            Material = GetComponent<Renderer>().material;
            MoveRightByForce();
            origincolor = Material.color;
        }

        // Update is called once per frame
        void Update()
        {
            //입력 처리
            //moveX = Input.GetAxis("Horizontal");

        }

        private void FixedUpdate()
        {
            //
            //rb.AddForce(Vector3.right * moveX * movepower, ForceMode.Force);
        }
        public void MoveRightByForce()
        {
            rb.AddForce(Vector3.right * movepower, ForceMode.Impulse);
        }
        public void MoveLeftByForce()
        {
            rb.AddForce(Vector3.left * movepower, ForceMode.Impulse);
        }
        public void ChangeColor()
        {
            Material.color = Color.red;
        }
        public void ResetColor()
        {
            Material.color = origincolor;
        }
    }
}