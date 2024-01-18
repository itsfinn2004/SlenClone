
using UnityEngine;
using UnityEngine.AI;

public class TestController : MonoBehaviour
{

    public Camera cam;
    public NavMeshAgent agent;
    public Transform player;
    public float moveSpeed = 5f;
    public bool CanMove = true;


    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(0))
        //{
        //      Debug.Log("mousebuttondown");
        //      Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        //      RaycastHit hit;

        //     if (Physics.Raycast(ray, out hit))
        //      {

        //          Debug.Log("hit");
        //          agent.SetDestination(hit.point);
        //      }


        //}
        if (CanMove == true)
        {
            // Calculate the direction from the enemy to the player
            Vector3 direction = player.position - transform.position;

            // Normalize the direction to get a unit vector
            direction.Normalize();

            // Move towards the player
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
