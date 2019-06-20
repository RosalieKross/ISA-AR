using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f; 
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); 

        if (Input.GetKey("d") ) // links
        {
            rb.AddForce(500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a")) // rechts
        {
            rb.AddForce(-500 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("w")) // vooruit
        {
            rb.AddForce(0, 0, 500 * Time.deltaTime);
        }

        if (Input.GetKey("s")) // achteruit
        {
            rb.AddForce(0, 0, -500 * Time.deltaTime);
        }

        if (Input.GetKey("p")) //jump
        {
            rb.AddForce(0, 600 * Time.deltaTime, 0);
        }
    }
}
