using UnityEngine;
using UnityEngine.AI;

namespace 
    MySample
{
    //마우스로 그라운드를 클릭하면 클릭한 지점으로 Agent를 이동시킨다
    public class AgentController : MonoBehaviour
    {
        #region Variables
        private NavMeshAgent agent;

        [SerializeField]private Vector3 worldposition; //이동 목표지점
        #endregion
        private void Start()
        {
            agent = GetComponent<NavMeshAgent>();
            
        }
        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SetDestinationToMausePosition();
            }
        }
        private void SetDestinationToMausePosition()
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}