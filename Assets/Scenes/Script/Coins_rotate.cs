using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Coins_rotate : MonoBehaviour
    
{
    private int rotation = 140;
    private int upDown = 0;
    private float speed = 1.5f;
    void Start()
    {
        StartCoroutine(ok());
    }
    void Update()
    {
        transform.Rotate(Vector3.up * Time.deltaTime * rotation);
    }
    private IEnumerator ok()
    {
        yield return new WaitForSecondsRealtime(2);
        while (true)
        {
            StartCoroutine(So());
            yield return new WaitForSecondsRealtime(2);
        }
    }
    private IEnumerator So()
    {
        while (upDown < 20)
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
            upDown += 1;
            yield return new WaitForSecondsRealtime(0.01f);
        }
        yield return new WaitForSecondsRealtime(0.5f);
        while (upDown > 0)
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
            upDown -= 1;
            yield return new WaitForSecondsRealtime(0.01f);
        }
        yield return new WaitForSecondsRealtime(0.5f);
    }
}
