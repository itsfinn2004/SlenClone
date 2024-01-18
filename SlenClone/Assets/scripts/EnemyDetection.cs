using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetection : MonoBehaviour
{
    //public GameObject Lasthit;
    //public Vector3 collision = Vector3.zero;
    //public float GroteDrawgizmo = 0.2f;
    //public int MaxLenght = 100;


    //private void Update()
    //{
    //    var ray = new Ray(this.transform.position, this.transform.forward);
    //    RaycastHit hit;
    //    if (Physics.Raycast(ray, out hit, MaxLenght))
    //    {
    //        Lasthit = hit.transform.gameObject;
    //        collision = hit.point;
    //        Debug.Log(hit.transform.gameObject);
    //    }



    //}

    TestController controller;
    public LayerMask layer;
    public float coneAngle = 45f;
    public float detectionRange = 10f;
    public GameObject enemy;


    private void Awake()
    {
     
        controller = enemy.GetComponent<TestController>();
    }
    void Update()
    {
        DetectObjectsInCone();
    }

    void DetectObjectsInCone()
    {
        // Cast rays in a cone pattern
        for (float angle = -coneAngle / 1; angle <= coneAngle / 1; angle += 5f)
        {
            // Calculate direction based on current angle
            Vector3 direction = Quaternion.Euler(0, angle, 0) * transform.forward;

            // Raycast in the calculated direction
            RaycastHit hit;
            if (Physics.Raycast(transform.position, direction, out hit, detectionRange))
            {
                // Check if the hit object is an enemy or something else
                if (hit.collider.CompareTag("Enemy"))
                {
                    // Handle enemy detection logic here
                    
                    Debug.Log("Enemy detected!");
                    
                    controller.CanMove = false;
                }
                else if (!hit.collider.CompareTag("Enemy"))
                {
                    Debug.Log("Enemy NOOOOOT detected");
                    controller.CanMove = true;
                }
                //werkt half omdat de bool van canmove de heletijd switched omdat meerdere rayscasts worden uitgezonden
            }

            // Visualize the rays (optional)
            Debug.DrawRay(transform.position, direction * detectionRange, Color.red);
        }
    }





}

  




    





