using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer_Select : MonoBehaviour
{

    public GameObject bouttonRouge2;
    public GameObject bouttonBleue2;
    public GameObject bouttonJaune2;
    public GameObject bouttonVert2;
    public GameObject bouttonNoir2;

    public GameObject bouttonRouge;
    public GameObject bouttonBleue;
    public GameObject bouttonJaune;
    public GameObject bouttonVert;
    public GameObject bouttonNoir;

    public float temps = 30f;   
    public float time = 30f;

    public TextMeshProUGUI timer;
    public TextMeshProUGUI Joueur;

    public Texture2D cursorTexture1;
    public CursorMode cursorMode1 = CursorMode.Auto;
    public Vector2 hotSpot1 = Vector2.zero;

    public Texture2D cursorTexture2;
    public CursorMode cursorMode2 = CursorMode.Auto;
    public Vector2 hotSpot2 = Vector2.zero;

    string joueur;

    int jouer = 0;
    int jouer2 = 0;

    int Perso_rouge = 0;
    int Perso_bleue = 0;
    int Perso_jaune = 0;
    int Perso_vert = 0;
    int Perso_noir = 0;


    private void Update()
    {
        Perso_rouge = PlayerPrefs.GetInt("Perso_rouge");
        Perso_bleue = PlayerPrefs.GetInt("Perso_bleue");
        Perso_jaune = PlayerPrefs.GetInt("Perso_jaune");
        Perso_vert = PlayerPrefs.GetInt("Perso_vert");
        Perso_noir = PlayerPrefs.GetInt("Perso_noir");

        Chrono1();

        if (Perso_rouge ==1)
        {
            Chrono2();
        }
        if (Perso_bleue == 1)
        {
            Chrono2();
        }
        if (Perso_jaune == 1)
        {
            Chrono2();
        }
        if (Perso_vert == 1)
        {
            Chrono2();
        }
        if (Perso_noir == 1)
        {
            Chrono2();
        }
    }

    void Chrono1()
    {

        UnityEngine.Cursor.SetCursor(cursorTexture1, hotSpot1, cursorMode1);
        timer.text = string.Format("{0:0}:{1:00}", Mathf.Floor(temps / 60), temps % 60);

        if (temps >= 0)
        {
            temps -= Time.deltaTime;
            jouer = 1;
            if(jouer == 1)
            {
                joueur = PlayerPrefs.GetString("Pseudo" ,"Pas de Pseudo");
                Joueur.text = "- " + joueur;
                Bouton();
            }
        }

        if (temps <= 0)
        {
            jouer = 1;
            if(jouer == 1)
            {
                joueur = (". . .");
                Joueur.text = ". . . ";
                Chrono2();
            }   
        } 
    }

    public void Chrono2()
    {

        UnityEngine.Cursor.SetCursor(cursorTexture2, Vector2.zero, cursorMode1);
        UnityEngine.Cursor.SetCursor(cursorTexture2, hotSpot2, cursorMode2);

        timer.text = string.Format("{0:0}:{1:00}", Mathf.Floor(time / 60), time % 60);
        
        if (time >= 0)
        {
            time -= Time.deltaTime;
            jouer = 1;
            if (jouer == 1)
            {
                joueur = PlayerPrefs.GetString("Pseudo2", "Pas de Pseudo");
                Joueur.text = "- " + joueur;
                Bouton2();
                test();
            }
        }

        if (time <= 0)
        {
            jouer = 0;
            if (jouer == 0)
            {
                UnityEngine.Cursor.SetCursor(null, Vector2.zero, cursorMode2);
                joueur = (". . .");
                Joueur.text = "Selection finished";
            }
        }
    }

    void Bouton()
    {
        bouttonRouge2.SetActive(false);
        bouttonBleue2.SetActive(false);
        bouttonJaune2.SetActive(false);
        bouttonVert2.SetActive(false);
        bouttonNoir2.SetActive(false);
    }

    void Bouton2()
    {
        bouttonRouge.SetActive(false);
        bouttonBleue.SetActive(false);
        bouttonJaune.SetActive(false);
        bouttonVert.SetActive(false);
        bouttonNoir.SetActive(false);

        bouttonRouge2.SetActive(true);
        bouttonBleue2.SetActive(true);
        bouttonJaune2.SetActive(true);
        bouttonVert2.SetActive(true);
        bouttonNoir2.SetActive(true);


    }

    void test()
    {
        if (Perso_rouge == 1)
        {
            bouttonRouge2.SetActive(false);
        }

        if (Perso_bleue == 1)
        {
            bouttonBleue2.SetActive(false);
        }

        if (Perso_jaune == 1)
        {
            bouttonJaune2.SetActive(false);
        }

        if (Perso_vert == 1)
        {
            bouttonVert2.SetActive(false);
        }

        if (Perso_noir == 1)
        {
            bouttonNoir2.SetActive(false);
        }
    }

    public void Desactive()
    {
        UnityEngine.Cursor.visible = false;
    }
}
