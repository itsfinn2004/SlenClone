
using UnityEngine;
using UnityEngine.AI;

public class TestController : MonoBehaviour
{
    public GameObject Cone;
    conedetection cone;
    public Camera cam;
    public NavMeshAgent agent;
    public Transform player;
    public float moveSpeed = 5f;
    public bool CanMove = true;

    private void Awake()
    {
        cone = Cone.GetComponent<conedetection>();
    }

    void Update()
    {
        if (!cone.inSight)
        {
            // Calculate the path to the player
            NavMeshPath path = new NavMeshPath();
            agent.CalculatePath(player.position, path);

            // Set the path to the agent
            agent.SetPath(path);

            // Ensure that the agent is not stopped
           agent.isStopped = false;
        }
        else
        {
            // Stop moving
           agent.isStopped = true;
            
        }
    }
}
    
