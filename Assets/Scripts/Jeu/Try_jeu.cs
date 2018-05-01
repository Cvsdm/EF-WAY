using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Try_jeu : MonoBehaviour {

    private Sauvegarde save;

    public void Buttontouch()
    {
            save = FindObjectOfType<Sauvegarde>();
            /*GameObject.Find("Terrain").gameObject.SetActive(true);
            GameObject.Find("Jauges").gameObject.SetActive(true);
            GameObject.Find("Canvas_Jeu").gameObject.SetActive(true);*/
            SceneManager.UnloadSceneAsync("lancé de dés");
            save.Disp_game();
        //start movement
    }
    

}
