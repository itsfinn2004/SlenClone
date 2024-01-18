using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    

    public Transform player;
    public float moveSpeed = 5f;

    void Update()
    {
        if (player != null)
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
