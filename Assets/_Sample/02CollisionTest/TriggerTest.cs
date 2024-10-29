using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MySample
{
    public class TriggerTest : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log($"OnTriggerEnter: {other.name}");
            //오른쪽으로 힘을 준다
            MoveObject move = other.GetComponent<MoveObject>();
            if( move != null )
            {
                move.MoveRightByForce();
                move.ChangeColor();
            }

        }
        private void OnTriggerStay(Collider other)
        {
            Debug.Log($"OnTriggerStay: {other.name}");
        }
        private void OnTriggerExit(Collider other)
        {
            Debug.Log($"OnTriggerExit: {other.name}");
            //오른쪽으로 힘을 준다
            MoveObject move = other.GetComponent<MoveObject>();
            if (move != null)
            {
                move.MoveRightByForce();
                move.ResetColor();
            }
        }
    }
}