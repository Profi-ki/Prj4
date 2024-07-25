using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 4;
    private float horizontal;
    private float vertical;
    public int force = 10;
    
    public Rigidbody rb;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.back * Time.deltaTime * speed * horizontal);
        transform.Translate(Vector3.right * Time.deltaTime * speed * vertical);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
    }

}
