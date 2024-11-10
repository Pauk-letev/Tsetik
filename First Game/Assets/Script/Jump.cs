using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    Rigidbody rb;
    float InHor = 0.01f;
    float InVert = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rb.transform.position += new Vector3(0,InVert,0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.transform.position += new Vector3(0, 0, InHor);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.transform.position -= new Vector3(0, 0, InHor);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.transform.position -= new Vector3(InHor, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.transform.position += new Vector3(InHor, 0, 0);
        }
    }
}
