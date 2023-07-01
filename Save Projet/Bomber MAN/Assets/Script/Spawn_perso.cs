using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_perso : MonoBehaviour
{
    public GameObject Perso_Rouge;
    public GameObject Perso_Bleue;
    public GameObject Perso_Jaune;
    public GameObject Perso_Vert; 
    public GameObject Perso_Noir;
   

    public GameObject Perso_Rouge2;
    public GameObject Perso_Bleue2;
    public GameObject Perso_Jaune2;
    public GameObject Perso_Vert2;
    public GameObject Perso_Noir2;
 

    [SerializeField]
    Transform[] Spawn;

    int Perso_rouge;
    int Perso_bleue;
    int Perso_jaune;
    int Perso_vert;
    int Perso_noir;

    int Perso_rouge2;
    int Perso_bleue2;
    int Perso_jaune2;
    int Perso_vert2;
    int Perso_noir2;

    //donne la corrspondance de int par rapport à PlayerPrefs
    void Perso()
    {
        Perso_rouge = PlayerPrefs.GetInt("Perso_rouge");
        Perso_bleue = PlayerPrefs.GetInt("Perso_bleue");
        Perso_jaune = PlayerPrefs.GetInt("Perso_jaune");
        Perso_vert = PlayerPrefs.GetInt("Perso_vert");
        Perso_noir = PlayerPrefs.GetInt("Perso_noir");

        Perso_rouge2 = PlayerPrefs.GetInt("Perso_rouge");
        Perso_bleue2 = PlayerPrefs.GetInt("Perso_bleue");
        Perso_jaune2 = PlayerPrefs.GetInt("Perso_jaune");
        Perso_vert2 = PlayerPrefs.GetInt("Perso_vert");
        Perso_noir2 = PlayerPrefs.GetInt("Perso_noir");
    }

    void Start()
    {

        Spawn = new Transform[transform.childCount];

        for (int a = 0; a < transform.childCount; a++)
        {
            Spawn[a] = transform.GetChild(a);
        }

        for (int b = 0; b < transform.childCount; b++)
        {
            Spawn[b] = transform.GetChild(b);
        }

        for (int c = 0; c < transform.childCount; c++)
        {
            Spawn[c] = transform.GetChild(c);
        }

        for (int d = 0; d < transform.childCount; d++)
        {
            Spawn[d] = transform.GetChild(d);
        }

        for (int e = 0; e < transform.childCount; e++)
        {
            Spawn[e] = transform.GetChild(e);
        }

        //Execute void Perso()
        Perso();

        // Verifie si un perso est selectionner et le fait apparaitre
      if (Perso_rouge == 1)
      {
          int a = Random.Range(0, transform.childCount);
          Perso_Rouge.transform.position = Spawn[a].transform.position;
          Instantiate(Perso_Rouge);
      }
   
      if (Perso_bleue == 1)
      {
          int b = Random.Range(0, transform.childCount);
          Perso_Bleue.transform.position = Spawn[b].transform.position;
          Instantiate(Perso_Bleue);
      }
   
      if (Perso_vert == 1)
      {
          int c = Random.Range(0, transform.childCount);
          Perso_Vert.transform.position = Spawn[c].transform.position;
          Instantiate(Perso_Vert);
      }
   
      if (Perso_jaune == 1)
      {
          int d = Random.Range(0, transform.childCount);
          Perso_Jaune.transform.position = Spawn[d].transform.position;
          Instantiate(Perso_Jaune);
      }
   
      if (Perso_noir == 1)
      {
          int e = Random.Range(0, transform.childCount);
          Perso_Noir.transform.position = Spawn[e].transform.position;
          Instantiate(Perso_Noir);
      }

        //pour le player 2
        if (Perso_rouge2 == 2)
        {
            int a = Random.Range(0, transform.childCount);
            Perso_Rouge2.transform.position = Spawn[a].transform.position;
            Instantiate(Perso_Rouge2);
        }

        if (Perso_bleue2 == 2)
        {
            int b = Random.Range(0, transform.childCount);
            Perso_Bleue2.transform.position = Spawn[b].transform.position;
            Instantiate(Perso_Bleue2);
        }

        if (Perso_vert2 == 2)
        {
            int c = Random.Range(0, transform.childCount);
            Perso_Vert2.transform.position = Spawn[c].transform.position;
            Instantiate(Perso_Vert2);
        }

        if (Perso_jaune2 == 2)
        {
            int d = Random.Range(0, transform.childCount);
            Perso_Jaune2.transform.position = Spawn[d].transform.position;
            Instantiate(Perso_Jaune2);
        }

        if (Perso_noir2 == 2)
        {
            int e = Random.Range(0, transform.childCount);
            Perso_Noir2.transform.position = Spawn[e].transform.position;
            Instantiate(Perso_Noir2);
        }
    }
}
