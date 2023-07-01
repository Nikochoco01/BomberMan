using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Depos_bombe2 : MonoBehaviour
{

    public float Force = 20f;
    public GameObject Mon_00;

    void Update()
    {
        if (Input.GetButtonDown("Bombe_2"))
        {
            GameObject Go = Instantiate(Mon_00, transform.position, Quaternion.identity);
            Go.GetComponent<Rigidbody>().AddForce(transform.TransformDirection(Vector3.forward) * Force);
        }
    }
}
