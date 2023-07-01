using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Afficher_Pseu : MonoBehaviour
{
    public TextMeshProUGUI Afficher;
    public TextMeshProUGUI Afficher2;

    string Pseudo;
    string Pseudo2;

    void Start()
    {
        AfficherPseudo();
        AfficherPseudo2();
    }

    public void AfficherPseudo()
    {
        Pseudo = PlayerPrefs.GetString("Pseudo", "pas de Pseudo");
        Afficher.text = "-  " + Pseudo;
    }

    public void AfficherPseudo2()
    {
        Pseudo2 = PlayerPrefs.GetString("Pseudo2", "pas de Pseudo");
        Afficher2.text = "-  " + Pseudo2;
    }
}
