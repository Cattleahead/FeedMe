using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveFish : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody rb;

    public float forwardSpeed;
    public float rotationSpeed;

    Vector3 EulerAngleVelocity = new Vector3(0, 100, 0);
    float rotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.drag = 1;
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.D))
            rb.AddRelativeTorque(Vector3.up * rotationSpeed);
        if(Input.GetKey(KeyCode.A))
            rb.AddRelativeTorque(Vector3.up * -rotationSpeed);


        if (Input.GetKey(KeyCode.W))
            rb.AddRelativeForce(Vector3.forward * forwardSpeed);


        if (Input.GetKey(KeyCode.S))
            rb.drag = 10;
        else
            rb.drag = 1;
    }
}
