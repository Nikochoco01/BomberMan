using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Choisir_Perso : MonoBehaviour
{
    
    public TextMeshProUGUI Afficher;

    public GameObject bouttonRouge;
    public GameObject bouttonBleue;
    public GameObject bouttonJaune;
    public GameObject bouttonVert;
    public GameObject bouttonNoir;

    int Perso_rouge;
    int Perso_bleue;
    int Perso_jaune;
    int Perso_vert;
    int Perso_noir;

    private void Start()
    {
    }
    public void Perso_Select_R()
    {
        Perso_rouge = 1;
        bouttonRouge.SetActive(false);
        PlayerPrefs.SetInt("Perso_rouge", 1);
        Afficher.text = ("Perso Rouge");
    }

    public void Perso_Select_B()
    {
        Perso_bleue = 1;
        bouttonBleue.SetActive(false);
        PlayerPrefs.SetInt("Perso_bleue", 1);
        Afficher.text = ("Perso Bleue");
    }

    public void Perso_Select_J()
    {
        Perso_jaune = 1;
        bouttonJaune.SetActive(false);
        PlayerPrefs.SetInt("Perso_jaune", 1);
        Afficher.text = ("Perso Jaune");
    }

    public void Perso_Select_V()
    {
        Perso_vert = 1;
        bouttonVert.SetActive(false);
        PlayerPrefs.SetInt("Perso_vert", 1);
        Afficher.text = ("Perso Vert");
    }

    public void Perso_Select_N()
    {
        Perso_noir = 1;
        bouttonNoir.SetActive(false);
        PlayerPrefs.SetInt("Perso_noir", 1);
        Afficher.text = ("Perso Noir");
    }
}
