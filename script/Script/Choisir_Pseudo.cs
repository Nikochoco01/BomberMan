using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Choisir_Pseudo : MonoBehaviour
{
    public TMP_InputField Player;
    string Pseudo;

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
}