using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Afficher_Pseudo : MonoBehaviour
{
    public TextMeshPro Afficher;
    string Pseudo;

    void Start()
    {
        AfficherPseudo();
    }


    public void AfficherPseudo()
    {
        Pseudo = PlayerPrefs.GetString("Pseudo" , "pas de Pseudo");
        Afficher.text = "-  " + Pseudo;
        Debug.Log("PseudoAfficher  " + Pseudo);
    }
}
