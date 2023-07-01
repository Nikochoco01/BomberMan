using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depos_bombe : MonoBehaviour
{

    public float Force = 20f;
    public GameObject Mon_00;
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject Go = Instantiate(Mon_00, transform.position, Quaternion.identity);
            Go.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * Force);  
        }

    }
}
