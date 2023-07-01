using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouv_perso : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // Pour ZQSD
        if (Input.GetKey(KeyCode.Z))
        {
            transform.Translate(0, 0, 0.1f);
            anim.SetBool("marche", true);
        }
        else
        {
            anim.SetBool("marche", false);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -0.1f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, 90f, 0);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            transform.Rotate(0, -90f, 0);
        }
    }
}
       








