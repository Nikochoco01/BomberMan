using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LienPerso1 : MonoBehaviour
{

    public GameObject Perso_Rouge;
    public GameObject Perso_Bleue;
    public GameObject Perso_Vert;
    public GameObject Perso_Jaune;
    public GameObject Perso_Noir;

    string Pseudo;
    int Perso;

    Choisir_Perso choisir_perso;

    void Start()
    {
        Pseudo = PlayerPrefs.GetString("Pseudo");
        Perso = PlayerPrefs.GetInt("");
    }
}
