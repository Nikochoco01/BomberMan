using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuppPerso : MonoBehaviour
{

    int Perso_rouge;
    int Perso_bleue;
    int Perso_jaune;
    int Perso_vert;
    int Perso_noir;

    public void SuppPerso_Rouge()
    {
        Perso_rouge = PlayerPrefs.GetInt("Perso_rouge");

        PlayerPrefs.DeleteKey("Perso_rouge");
    }

    public void SuppPerso_Bleue()
    {
        Perso_bleue = PlayerPrefs.GetInt("Perso_bleue");

        PlayerPrefs.DeleteKey("Perso_bleue");
    }

    public void SuppPerso_Jaune()
    {
        Perso_jaune = PlayerPrefs.GetInt("Perso_jaune");

        PlayerPrefs.DeleteKey("Perso_jaune");
    }

    public void SuppPerso_Vert()
    {
        Perso_vert = PlayerPrefs.GetInt("Perso_vert");

        PlayerPrefs.DeleteKey("Perso_vert");
    }

    public void SuppPerso_Noir()
    {
        Perso_noir = PlayerPrefs.GetInt("Perso_noir");

        PlayerPrefs.DeleteKey("Perso_noir");
    }
}
