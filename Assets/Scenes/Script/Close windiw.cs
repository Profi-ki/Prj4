using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Closewindiw : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(gameObject);
        }
    }
}
