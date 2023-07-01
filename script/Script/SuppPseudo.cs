using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuppPseudo : MonoBehaviour
{
    string Pseudo;
    string Pseudo2;

    public void SupprimPseudo()
    {
        Pseudo = PlayerPrefs.GetString("Pseudo" , Pseudo);

        PlayerPrefs.DeleteKey("Pseudo");
        Debug.Log("Pseudo Supprimer  " + Pseudo);
    }

    public void SupprimPseudo2()
    {
        Pseudo2 = PlayerPrefs.GetString("Pseudo2" ,Pseudo2);

        PlayerPrefs.DeleteKey("Pseudo2");

        Debug.Log("Pseudo Supprimer  " + Pseudo2);
    }

    
}
