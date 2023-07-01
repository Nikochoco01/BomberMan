using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LienJoueur1 : MonoBehaviour
{
    Choisir_Perso choix_perso1;
    Choisir_Perso2 choix_perso2;
    float temps;

    void Start()
    {
        choix_perso1 = GameObject.Find("Choix_perso1").GetComponent<Choisir_Perso>();
        choix_perso2 = GameObject.Find("Choix_perso2").GetComponent<Choisir_Perso2>();
        temps = GameObject.Find("Timer_Select").GetComponent<Timer_Select>().temps;
    }

    void Update()
    {
        if (temps <= 30)
        {
            choix_perso1.enabled = true;
            choix_perso2.enabled = false;
        }
    }
}
