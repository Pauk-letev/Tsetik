using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public GameObject gmOb;
    public Transform pos; 

    Rigidbody rb;

    float InHor = 0.01f;
    float InVert = 0.01f;

    [SerializeField]float speed;
    [SerializeField] float jumpF;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(Input.GetKey(KeyCode.F))
        {
            Debug.Log("Love you");

            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
            Instantiate(gmOb, pos);
        }
    }
    void Movement()
    {
            InHor = Input.GetAxis("Vertical");
            InVert = Input.GetAxis("Horizontal");
            rb.AddForce(Vector3.forward * InHor);
            rb.AddForce(Vector3.right * InVert);

            if (Input.GetKey(KeyCode.Space))
            {
                rb.AddForce(Vector3.up * jumpF, ForceMode.Impulse);
            }
            /*if (Input.GetKey(KeyCode.W))
            {
                rb.transform.position += new Vector3(0, 0, InHor * speed);
            }
            if (Input.GetKey(KeyCode.S))
            {
                rb.transform.position -= new Vector3(0, 0, InHor * speed);
            }
            if (Input.GetKey(KeyCode.A))
            {
                rb.transform.position -= new Vector3(InHor * speed, 0, 0);
            }
            if (Input.GetKey(KeyCode.D))
            {
                rb.transform.position += new Vector3(InHor * speed, 0, 0);
            }*/
        }
}
