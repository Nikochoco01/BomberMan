using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;
using TMPro;


public class LoaderBomber : MonoBehaviour
{

    public GameObject LoadingScreen;
    public Slider BarreChargement;
    public Text progressText;

   public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsync(sceneIndex));
    }

    IEnumerator LoadAsync(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        LoadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            BarreChargement.value = progress;
            progressText.text = progress * 100 + "%";
            yield return null;

        }
    }
}
