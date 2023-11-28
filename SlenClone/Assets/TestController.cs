
using UnityEngine;
using UnityEngine.AI;

public class TestController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
    

    // Update is called once per frame
    void Update()
    {
      if(Input.GetMouseButtonDown(0))
      {
            Debug.Log("mousebuttondown");
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

           if (Physics.Raycast(ray, out hit))
            {
                
                Debug.Log("hit");
                agent.SetDestination(hit.point);
            }

            
      }
    }
}
