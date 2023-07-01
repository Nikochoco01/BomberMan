using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Afficher_Pseudo2 : MonoBehaviour
{
    public TextMeshPro Afficher2;
    string Pseudo2;

    void Start()
    {
        AfficherPseudo2();
    }


    public void AfficherPseudo2()
    {
        Pseudo2 = PlayerPrefs.GetString("Pseudo2", "pas de Pseudo2");
        Afficher2.text = "-  " + Pseudo2;
        Debug.Log("PseudoAfficher  " + Pseudo2);
    }
}
