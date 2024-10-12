using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingSceen : MonoBehaviour
{ 
    private static LoadingSceen instance;

    public static LoadingSceen Instance { get { return instance; } }

    [SerializeField] private Image backgroundImage;
    [SerializeField] private Image progressCircle;


    private void Awake()
    {
        instance = this;
    }

    public void ShowLoadScreen(string sceneName)
    {
        StartCoroutine(LoadScene(sceneName));
    }

    IEnumerator LoadScene(string sceneName)
    {
        backgroundImage.gameObject.SetActive(true);
        float t = 0;
        Color original = new Color(0, 0, 0, 0);
        Color target = new Color(0, 0, 0, 1);
        while (t <= 1)
        {
            t += Time.deltaTime;
            backgroundImage.color = Color.Lerp(original, target, t);
            yield return null;
        }
        progressCircle.gameObject.SetActive(true);

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(sceneName);

        while(!asyncOperation.isDone)
        {
            progressCircle.fillAmount = asyncOperation.progress;
            yield return null;
        }
    }

}
