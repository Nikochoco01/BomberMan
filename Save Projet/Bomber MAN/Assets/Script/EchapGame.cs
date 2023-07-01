using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EchapGame : MonoBehaviour
{
    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public string EndScreen;
    public GameObject Loading;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Loading.SetActive(true);
            SceneManager.LoadScene(EndScreen);
            UnityEngine.Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
            UnityEngine.Cursor.visible = true;
        }
    }
}
