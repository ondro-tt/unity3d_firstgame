using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rB;
    // Start is called before the first frame update
    public float forwardForce = 20000f;
    public float sideWayForce = 500f;
    // Update is called once per frame
    void FixedUpdate()
    {

        rB.AddForce(0, 0, forwardForce * Time.deltaTime);
        if (Input.GetKey("d")) {
            rB.AddForce(sideWayForce * Time.deltaTime, 0,0);
        }
        if (Input.GetKey("a"))
        {
            rB.AddForce(-sideWayForce * Time.deltaTime, 0, 0);
        }

    }
}
