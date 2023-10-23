using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    
    public float moveSpeed = 5.0f; // Adjust the speed as needed

    private void Update()
    {
        // Get input from "A" and "D" keys
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput!=0){
	            Debug.Log("Horizontal input: " + horizontalInput);
        }

        // Calculate the new position
        Vector3 newPosition = transform.position + new Vector3(horizontalInput * moveSpeed * Time.deltaTime, 0, 0);

        // Move the object
        transform.position = newPosition;
    }
}