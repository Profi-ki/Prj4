using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rotate : MonoBehaviour
{

    private int rotation = 280;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotation);
        }
        if (Input.GetMouseButtonDown(1))
        {
            transform.Rotate(Vector3.down * Time.deltaTime * rotation);
        }
    }
}
