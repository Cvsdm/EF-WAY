using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScripts : MonoBehaviour
{
    /*private Sauvegarde save;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
    }*/

    public void SceneLoader (int SceneIndex)
    {
        //save.Save_Parameters();
        SceneManager.LoadScene(SceneIndex);
    }

}
