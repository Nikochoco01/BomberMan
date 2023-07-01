using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Choisir_Perso2 : MonoBehaviour
{

    public TextMeshProUGUI Afficher2;

    public GameObject bouttonRouge2;
    public GameObject bouttonBleue2;
    public GameObject bouttonJaune2;
    public GameObject bouttonVert2;
    public GameObject bouttonNoir2;

    int Perso_rouge;
    int Perso_bleue;
    int Perso_jaune;
    int Perso_vert;
    int Perso_noir;

    public void Start()
    {
    }
    public void Perso_Select_R2()
    {
        Perso_rouge = 2;
        bouttonRouge2.SetActive(false);
        PlayerPrefs.SetInt("Perso_rouge", 2);
        Afficher2.text = ("Perso Rouge");
    }

    public void Perso_Select_B2()
    {
        Perso_bleue = 2;
        bouttonBleue2.SetActive(false);
        PlayerPrefs.SetInt("Perso_bleue", 2);
        Afficher2.text = ("Perso Bleue");
    }

    public void Perso_Select_J2()
    {
        Perso_jaune = 2;
        bouttonJaune2.SetActive(false);
        PlayerPrefs.SetInt("Perso_jaune", 2);
        Afficher2.text = ("Perso Jaune");
    }

    public void Perso_Select_V2()
    {
        Perso_vert = 2;
        bouttonVert2.SetActive(false);
        PlayerPrefs.SetInt("Perso_vert", 2);
        Afficher2.text = ("Perso Vert");
    }

    public void Perso_Select_N2()
    {
        Perso_noir = 2;
        bouttonNoir2.SetActive(false);
        PlayerPrefs.SetInt("Perso_noir", 2);
        Afficher2.text = ("Perso Noir");
    }
}
