using UnityEngine;

public class MoveBackAndForth : MonoBehaviour
{
    public float speed = 5f;
    public float distance = 5f;

    private Vector3 initialPosition;

    private void Start()
    {
        // Store the initial position of the object
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the new position based on the sine function
        float newPositionX = initialPosition.x + Mathf.Sin(Time.time * speed) * distance;

        // Update the object's position
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
