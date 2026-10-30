using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //Declaring a new speed variable
    public float speed = 40.0f;

    //Setting the projectiles speed vairable based on the time in seconds
    //Also adjusting in Insoector
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
