using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Choisir_Pseudo : MonoBehaviour
{
    public TMP_InputField Player;
    public TMP_InputField Player2;
    string Pseudo;
    string Pseudo2;

    public void entrerPseudo()
    {
        Pseudo = Player.text;
        PlayerPrefs.SetString("Pseudo", Pseudo);
        Debug.Log("Joueur " + Pseudo);
     }

    public void RegisterPseudo()
    {
        PlayerPrefs.GetString(Pseudo);
        Debug.Log("Pseudo Register " + Pseudo);
    }

    public void entrerPseudo2()
    {
        Pseudo2 = Player2.text;
        PlayerPrefs.SetString("Pseudo2", Pseudo2);
        Debug.Log("Joueur " + Pseudo2);
    }

    public void RegisterPseudo2()
    {
        PlayerPrefs.GetString(Pseudo2);
        Debug.Log("Pseudo Register " + Pseudo2);
    }
}