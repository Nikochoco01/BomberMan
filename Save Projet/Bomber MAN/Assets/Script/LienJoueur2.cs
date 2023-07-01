using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LienJoueur2 : MonoBehaviour
{
    Choisir_Perso choix_perso1;
    Choisir_Perso2 choix_perso2;
    float time;

    void Start()
    {
        choix_perso1 = GameObject.Find("Choix_perso1").GetComponent<Choisir_Perso>();
        choix_perso2 = GameObject.Find("Choix_perso2").GetComponent<Choisir_Perso2>();
        time = GameObject.Find("Timer_Select").GetComponent<Timer_Select>().time;
    }

    void Update()
    {
        if(time <= 29.9)
        {
           choix_perso1.enabled = false;
           choix_perso2.enabled = true;
        }
    }
}
