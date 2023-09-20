using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var position = new Vector3(Random.Range(-10f, 10f), 0, 0);
        this.GetComponent<Transform>().position = position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
