using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchapGame : MonoBehaviour
{
    public string EndScreen;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel(EndScreen);
        }
    }
}
