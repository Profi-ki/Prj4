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

    public bool onIsland;
    
    public Rigidbody rb;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.back * Time.deltaTime * speed * horizontal);
        transform.Translate(Vector3.right * Time.deltaTime * speed * vertical);

        if (Input.GetKeyDown(KeyCode.Space) && onIsland == true)
        {
            rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            onIsland = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Island"))
        {
            onIsland = true;
        }
    }
}
