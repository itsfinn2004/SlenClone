using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conedetection : MonoBehaviour
{
    public bool inSight = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Enemy"))
        {
            Debug.Log("enemy is in your sight"); 
            inSight = true;
        }
        else
        {
            Debug.Log("just noooooooo but inside");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("enemy is out of your sight");
            inSight = false;
        }
        else
        {
            Debug.Log("just noooooooo but outside");
        }
    }
}
