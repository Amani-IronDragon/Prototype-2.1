using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    void Start()
    {


        Debug.Log(animalPrefabs[0]);
         Debug.Log(animalPrefabs[1]);
         Debug.Log(animalPrefabs[2]);

        Debug.Log(animalPrefabs.Length);
    }
}
