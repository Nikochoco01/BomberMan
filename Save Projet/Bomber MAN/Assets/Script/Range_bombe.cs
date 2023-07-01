using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Range_bombe : MonoBehaviour
{
    public GameObject Bombe;

    // range = devant derrière 
    // range2 = droite gauche 

    public BoxCollider range1;
    public BoxCollider range2;

    public float r1ScaleX;
    public float r1ScaleY;
    public float r1ScaleZ;
    public float r2ScaleX;
    public float r2ScaleY;
    public float r2ScaleZ;

    public float Temps;

    private void Start()
    {
        // Scale range 1
        r1ScaleX = 0.5f;
        r1ScaleY = 0.5f;
        r1ScaleZ = 2f;

        // Scale range 2
        r2ScaleX = 2f;
        r2ScaleY = 0.5f;
        r2ScaleZ = 0.5f;
    }
    public void Update()
    {
        Temps = GameObject.Find("00 : 00(TMP)").GetComponent<Timer_Game>().temps;

        if(Temps <=270f)
        {
            r1ScaleZ = 3;
            r2ScaleX = 3;
            range1.size = new Vector3(r1ScaleX , r1ScaleY, r1ScaleZ);
            range2.size = new Vector3(r2ScaleX, r2ScaleY, r2ScaleZ);
        }

        if (Temps <= 240f)
        {
            r1ScaleZ = 4;
            r2ScaleX = 4;
            range1.size = new Vector3(r1ScaleX, r1ScaleY, r1ScaleZ);
            range2.size = new Vector3(r2ScaleX, r2ScaleY, r2ScaleZ);
        }

        if (Temps <= 210f)
        {
            r1ScaleZ = 5;
            r2ScaleX = 5;
            range1.size = new Vector3(r1ScaleX, r1ScaleY, r1ScaleZ);
            range2.size = new Vector3(r2ScaleX, r2ScaleY, r2ScaleZ);
        }

        if (Temps <= 180f)
        {
            r1ScaleZ = 6;
            r2ScaleX = 6;
            range1.size = new Vector3(r1ScaleX, r1ScaleY, r1ScaleZ);
            range2.size = new Vector3(r2ScaleX, r2ScaleY, r2ScaleZ);
        }

        if (Temps <= 150f)
        {
            r1ScaleZ = 7;
            r2ScaleX = 7;
            range1.size = new Vector3(r1ScaleX, r1ScaleY, r1ScaleZ);
            range2.size = new Vector3(r2ScaleX, r2ScaleY, r2ScaleZ);
        }
    }
}