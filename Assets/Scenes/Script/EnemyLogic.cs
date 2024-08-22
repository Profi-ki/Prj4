using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLogic : MonoBehaviour
{
    private Transform plr;
    private float speed = 1.5f;
    private float attackrange = 3f;
    private float distanceToPlr;
    private Vector3 direction;
    void Start()
    {
        plr = GameObject.Find("player").transform;
    }

    void Update()
    {
        distanceToPlr = Vector3.Distance(transform.position, plr.position);

        if (distanceToPlr <= attackrange)
        {
            direction = (plr.position - transform.position).normalized;

            transform.Translate(direction * Time.deltaTime * speed);
        }
    }
}
