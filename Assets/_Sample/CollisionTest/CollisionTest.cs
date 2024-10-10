using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    public class CollisionTest : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            Debug.Log($"OnCollisionEnter: {collision.gameObject.name}");
            //왼쪽으로 힘을 준다
            MoveObject move = collision.gameObject.GetComponent<MoveObject>();
            if( move != null )
            {
                move.MoveLeftByForce();
            }
        }
        private void OnCollisionStay(Collision collision)
        {
            Debug.Log($"OnCollisionStay: {collision.gameObject.name}");
        }
        private void OnCollisionExit(Collision collision)
        {
            Debug.Log($"OnCollisionExit: {collision.gameObject.name}");
            //왼쪽으로 힘을 준다
            MoveObject move = collision.gameObject.GetComponent<MoveObject>();
            if (move != null)
            {
                move.MoveLeftByForce();
            }
        }
    }
}