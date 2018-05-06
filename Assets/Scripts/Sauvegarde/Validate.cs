using UnityEngine;
using UnityEngine.UI;

public class Validate : MonoBehaviour {

    private int nom = 0;
    private bool bac_s = false;
    private bool bac_es = false;
    public Button button;
    public InputField name_player;
    private Sauvegarde save;

    void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        button.interactable = false;

    }

    // Update is called once per frame
    void Update () {

        if (nom == 1 && (bac_s == true || bac_es == true))
        {
            save.Set_player(name_player.text);

            if (bac_s == true)//0:  s et 1: es/sti2d
                save.Set_bac(0);
            else
                save.Set_bac(1);

            save.Save_Parameters();
            button.interactable = true;
        }
     }

    public void Edit_nom ()
    {
        //Debug.Log("nom: " + name_player.text);
        nom = 1;
    }

    public void Bac_change_s ()    
    {
        bac_s = true;
        bac_es = false;
        //Debug.Log("bool_m " + gender_m);
    }

    public void Bac_change_es()       
    {
        bac_es = true;
        bac_s = false;
        //Debug.Log("bool_f " + gender_f);
    }

    /*public void Button_Start()
    {
        //StartCoroutine(save.Lancer_scene_dés());
        SceneManager.LoadScene("Jeu");
    }*/
}
