using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Choisir_Pseudo2 : MonoBehaviour
{
    public TMP_InputField Player2;
    string Pseudo2;


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
