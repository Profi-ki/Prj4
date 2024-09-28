using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coinsrotate : MonoBehaviour
    
{
    private int rotation = 140;
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotation);
    }
}
