using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScripts : MonoBehaviour
{
    public void SceneLoader (int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

    public void SceneLoader_name(string SceneName)
    {
        SceneManager.LoadScene(SceneName);//,LoadSceneMode.Additive);
    }

}
