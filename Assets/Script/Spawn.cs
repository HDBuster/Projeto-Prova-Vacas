using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawn;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnVaca", 1, 5);
    }

    void SpawnVaca()
    {
        Instantiate(spawn, this.transform.position, Quaternion.identity);
    }
}
