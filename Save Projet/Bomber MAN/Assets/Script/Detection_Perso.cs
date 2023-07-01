using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detection_Perso : MonoBehaviour
{
    public GameObject perso_homme;
    public GameObject perso_femme;
    public bool Enter = true;
    public bool Exit = true;

    private void OnTriggerEnter()
    {
        if (Enter)
        {
            Debug.Log("Spawn");
        }   
    }
     
    private void OnTriggerExit()
    {
        if (Exit)
        {
            Debug.Log("Mort");
        }
    }   
}
