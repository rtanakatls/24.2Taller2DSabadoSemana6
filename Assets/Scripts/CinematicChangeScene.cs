using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;

public class CinematicChangeScene : MonoBehaviour
{
    private static CinematicChangeScene instance;
    public static CinematicChangeScene Instance {  get { return instance; } }

    private PlayableDirector cinematic;

    private void Awake()
    {
        instance = this;
        cinematic = GetComponent<PlayableDirector>();
    }

    public void ChangeScene(string sceneName)
    {
        StartCoroutine(Execute(sceneName));
    }

    private IEnumerator Execute(string sceneName)
    {
        cinematic.Play();
        while (cinematic.state == PlayState.Playing)
        {
            yield return null;
        }
        LoadingSceen.Instance.ShowLoadScreen(sceneName);
    }

}
