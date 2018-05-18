using UnityEngine;
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

    public void Return_MainMenu()
    {
        Destroy(GameObject.Find("SauvegardeController"));
        SceneManager.LoadScene("MainMenu");
    }
}
