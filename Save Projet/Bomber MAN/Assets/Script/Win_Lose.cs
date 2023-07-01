using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Win_Lose : MonoBehaviour
{
    public TextMeshProUGUI affiche1;
    public TextMeshProUGUI affiche2;

    int Perso_rouge;
    int Perso_bleue;
    int Perso_jaune;
    int Perso_vert;
    int Perso_noir;

    float temps;

    private void Start()
    {
        Perso_rouge = PlayerPrefs.GetInt("Perso_rouge");
        Perso_bleue = PlayerPrefs.GetInt("Perso_bleue");
        Perso_jaune = PlayerPrefs.GetInt("Perso_jaune");
        Perso_vert = PlayerPrefs.GetInt("Perso_vert");
        Perso_noir = PlayerPrefs.GetInt("Perso_noir");

        if (Perso_rouge == 1)
        {
            affiche1.text = ("Gagner");
            affiche2.text = ("perdu");
        }

        if (Perso_rouge == 2)
        {
            affiche1.text = ("Perdu");
            affiche2.text = ("Gagner");
        }

        if (Perso_bleue == 1)
        {
            affiche1.text = ("Gagner");
            affiche2.text = ("perdu");
        }

        if (Perso_bleue == 2)
        {
            affiche1.text = ("Perdu");
            affiche2.text = ("Gagner");
        }

        if (Perso_jaune == 1)
        {
            affiche1.text = ("Gagner");
            affiche2.text = ("perdu");
        }

        if (Perso_jaune == 2)
        {
            affiche1.text = ("Perdu");
            affiche2.text = ("Gagner");
        }

        if (Perso_vert == 1)
        {
            affiche1.text = ("Gagner");
            affiche2.text = ("perdu");
        }

        if (Perso_vert == 2)
        {
            affiche1.text = ("Perdu");
            affiche2.text = ("Gagner");
        }

        if (Perso_noir == 1)
        {
            affiche1.text = ("Gagner");
            affiche2.text = ("perdu");
        }

        if (Perso_noir == 2)
        {
            affiche1.text = ("Perdu");
            affiche2.text = ("Gagner");
        }

        Egalité();
    }

    void Egalité()
    {      
       if (Perso_rouge == 3)
       {
           affiche1.text = ("egalite");
           affiche2.text = ("egalite");
       }

       if (Perso_bleue == 3)
       {
           affiche1.text = ("egalite");
           affiche2.text = ("egalite");
       }

       if (Perso_jaune == 3)
       {
           affiche1.text = ("egalite");
           affiche2.text = ("egalite");
       }

       if (Perso_vert == 3)
       {
           affiche1.text = ("egalite");
           affiche2.text = ("egalite");
       }

       if (Perso_noir == 3)
       {
           affiche1.text = ("egalite");
           affiche2.text = ("egalite");
       }
    }
}
