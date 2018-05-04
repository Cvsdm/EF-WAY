﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScripts : MonoBehaviour
{
    private Sauvegarde save;

    public void SceneLoader (int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void SceneLoader_name(string SceneName)
    {
        SceneManager.LoadScene(SceneName,LoadSceneMode.Additive);
    }

    public void SceneUnLoader_name(string SceneName)
    {
        SceneManager.UnloadSceneAsync(SceneName);
    }

    public void Disp_after_Stop(string scene)
    {
        save = FindObjectOfType<Sauvegarde>();
        SceneManager.UnloadSceneAsync(scene);

        if (save.Get_nextmove() == 0)
            StartCoroutine(save.Load_scenes(2f));
        else { iTween.Resume(); }
    }
}
