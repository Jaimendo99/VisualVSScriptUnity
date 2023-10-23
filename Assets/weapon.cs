using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour {
    // Start is called before the first frame update
    public Transform firePoint;
    public GameObject bullet;
    public float moveSpeed = 5.0f; // Adjust the speed as needed
    
    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        // Calculate the new position
        Vector3 newPosition = new Vector3(horizontalInput , 0, 0);
        transform.Translate(newPosition*moveSpeed*Time.deltaTime);

        // Move the object
        if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }
    
    void Shoot() 
    {
        // shooting logic
        // Debug.Log("Shooting");
        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
}
