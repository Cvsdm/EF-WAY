using UnityEngine;
using UnityEngine.UI;

public class Gerer_Assos : MonoBehaviour {

    private Sauvegarde save;

    public GameObject canvas;
    public GameObject canvas_suppress;
    public Text text;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;


    public void Initialize () {

        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button3.gameObject.SetActive(true);
        canvas_suppress.SetActive(true);
        canvas.SetActive(false);

        save = FindObjectOfType<Sauvegarde>();
        if (save.Get_langue() == 0)
            text.text = "Tu es déjà inscrit dans 3 associations.\n Laquelle veux-tu supprimer ? ";
        else
            text.text = "You're already enrolled in 3 associations.\n Which one do you want to get out of ?";

        button1.GetComponentInChildren<Text>().text = save.Get_Tab_assos(0);
        button2.GetComponentInChildren<Text>().text = save.Get_Tab_assos(1);
        button3.GetComponentInChildren<Text>().text = save.Get_Tab_assos(2);
    }
	
	// Update is called once per frame
	public void Button_clicked (int i) {
        if (i < 3)
        {
            if (save.Get_langue() == 0)
                text.text = "Vous ne faites plus parti de " + save.Get_Tab_assos(i);
            else
                text.text = "You are no longer a part of " + save.Get_Tab_assos(i);

            save.Set_Tab_assos(i, "none");

            button1.gameObject.SetActive(false);
            button2.gameObject.SetActive(false);
            button3.gameObject.SetActive(false);
            button4.GetComponentInChildren<Text>().text = "Continue";
        }
        else 
        {
            canvas.SetActive(true);
            canvas_suppress.SetActive(false);
        }
	}
}
