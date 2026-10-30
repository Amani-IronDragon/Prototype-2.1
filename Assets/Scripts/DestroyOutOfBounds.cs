using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    //Creating the speed for the topBound/lowerBound z-axis position
    private float topBound = 30;
    private float lowerBound = -30;

    if(transform.position.z > topBound)
    {
        Destroy(gameObject);
    }
    else if (transform.position.z < lowerBound)
    {
        Destroy(gameObject);
    }
}
