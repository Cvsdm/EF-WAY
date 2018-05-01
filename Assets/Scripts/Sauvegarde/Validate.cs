using UnityEngine;
using UnityEngine.UI;

public class Validate : MonoBehaviour {

    private int nom = 0;
    private bool gender_m = false;
    private bool gender_f = false;
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

        if (nom == 1 && (gender_m == true || gender_f == true))
        {
            save.Set_player(name_player.text);

            if (gender_m == true)//0:  masculin et 1: feminin
                save.Set_gender(0);
            else
                save.Set_gender(1);

            save.Save_Parameters();
            button.interactable = true;
        }
     }

    public void Edit_nom ()
    {
        //Debug.Log("nom: " + name_player.text);
        nom = 1;
    }

    public void Gender_change_m ()
    {
        gender_m = true;
        gender_f = false;
        //Debug.Log("bool_m " + gender_m);
    }

    public void Gender_change_f()
    {
        gender_f = true;
        gender_m = false;
        //Debug.Log("bool_f " + gender_f);
    }

    /*public void Button_Start()
    {
        //StartCoroutine(save.Lancer_scene_dés());
        SceneManager.LoadScene("Jeu");
    }*/
}
