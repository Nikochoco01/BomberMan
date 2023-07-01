using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Mort_Vivant : MonoBehaviour
{
    GameObject BB_rouge;
    GameObject BB_bleue;
    GameObject BB_jaune;
    GameObject BB_vert;
    GameObject BB_noir;

    GameObject BB_rouge2;
    GameObject BB_bleue2;
    GameObject BB_jaune2;
    GameObject BB_vert2;
    GameObject BB_noir2;

    public GameObject LoadingScreen;
    public Slider BarreChargement;
    public Text progressText;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    int Rouge;
    int Bleue;
    int Jaune;
    int Vert;
    int Noir;

    int BB_R;
    int BB_B;
    int BB_J;
    int BB_V;
    int BB_N;

    int BB_R2;
    int BB_B2;
    int BB_J2;
    int BB_V2;
    int BB_N2;

    public float temps;

    private void Start()
    {
        Rouge = PlayerPrefs.GetInt("Perso_rouge");
        Bleue = PlayerPrefs.GetInt("Perso_bleue");
        Jaune = PlayerPrefs.GetInt("Perso_jaune");
        Vert = PlayerPrefs.GetInt("Perso_vert");
        Noir = PlayerPrefs.GetInt("Perso_noir");
    }

    void Update()
    {
        BB_rouge = GameObject.Find("BB_Rouge(Clone)");
        BB_bleue = GameObject.Find("BB_Bleue(Clone)");
        BB_jaune = GameObject.Find("BB_Jaune(Clone)");
        BB_vert = GameObject.Find("BB_Vert(Clone)");
        BB_noir = GameObject.Find("BB_Noir(Clone)");

        BB_rouge2 = GameObject.Find("BB_Rouge 2(Clone)");
        BB_bleue2 = GameObject.Find("BB_Bleue 2(Clone)");
        BB_jaune2 = GameObject.Find("BB_Jaune 2(Clone)");
        BB_vert2 = GameObject.Find("BB_Vert 2(Clone)");
        BB_noir2 = GameObject.Find("BB_Noir 2(Clone)");

        temps = GameObject.Find("00 : 00(TMP)").GetComponent<Timer_Game>().temps;
        UnityEngine.Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);

        // 1 = valeur de selection joueur 1
        // 2 = valeur de selection joueur 2
        // 0 = mort
        // 3 = egalite pour le script win_lose

        if (Rouge == 1)
        {        
            if (!BB_rouge)
            {
                PlayerPrefs.SetInt("Perso_rouge", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if(temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_rouge", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if(Bleue == 1)
        {
            if (!BB_bleue)
            {
                PlayerPrefs.SetInt("Perso_bleue", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_bleue", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if (Jaune == 1)
        {
            if (!BB_jaune)
            {
                PlayerPrefs.SetInt("Perso_jaune", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_jaune", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if (Vert == 1)
        {
            if (!BB_vert)
            {
                PlayerPrefs.SetInt("Perso_vert", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_vert", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if (Noir == 1)
        {
            if (!BB_noir)
            {
                PlayerPrefs.SetInt("Perso_noir", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_noir", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        // Joueur 2

        if(Rouge == 2)
        {
            if (!BB_rouge2)
            {
                PlayerPrefs.SetInt("Perso_rouge", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_rouge", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if (Bleue == 2)
        {
            if (!BB_bleue2)
            {
                PlayerPrefs.SetInt("Perso_bleue", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_bleue", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if (Jaune == 2)
        {
            if (!BB_jaune2)
            {
                PlayerPrefs.SetInt("Perso_jaune", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_jaune", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if (Vert == 2)
        {
            if (!BB_vert2)
            {
                PlayerPrefs.SetInt("Perso_vert", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_vert", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }

        if (Noir == 2)
        {
            if (!BB_noir2)
            {
                PlayerPrefs.SetInt("Perso_noir", 0);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }

            if (temps <= 1f)
            {
                PlayerPrefs.SetInt("Perso_noir", 3);
                UnityEngine.Cursor.visible = true;
                LoadingScreen.SetActive(true);
                SceneManager.LoadScene("Win_Lose");
            }
        }
    }
}
