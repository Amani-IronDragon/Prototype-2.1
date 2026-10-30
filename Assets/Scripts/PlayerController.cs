using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Establishing left/right keys
    public float horizontalInput;

    //Establishing the player's frame speed
    public float speed = 10.0f;

    //New range based on x-value, preventing the player from moving past this value
    public float xRange = 10;

    //Creating a new food prefab variable
    public GameObject projectilePrefab;

    //Keeps the player within bounds
    void Update()
    {
        //Create the horizontal input axis
        horizontalInput = Input.GetAxis("Horizontal");

        //Their relative translation speed in respect to time
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        
        //Creating an if statement to maintain the player within bounds
        if(transform.position.x < xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Creating an if-statement for a spacebar check
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
