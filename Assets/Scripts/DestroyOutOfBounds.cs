﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // if the position is over the bound the gameObject is destroy
        if (transform.position.z > topBound || transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
