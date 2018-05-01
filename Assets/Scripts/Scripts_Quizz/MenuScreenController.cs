using UnityEngine;
using UnityEngine.UI;

public class MenuScreenController : MonoBehaviour
{
    public Text Titletext;
    public Text Rulestext;
    private Sauvegarde save;

    public void Start()
    {
        save = FindObjectOfType<Sauvegarde>();

        if (save.Get_counter() == 24 || save.Get_counter() == 83)
        {
            Titletext.text = "Projet Voltaire";
            Rulestext.text = "Une phrase vous est affichée.\n Répondez VRAI si elle contient une faute.\n Répondez FAUX si elle ne contient PAS de faute.";
                }
        else if (save.Get_counter() == 90)
        {
            Titletext.text = "TOEIC";
            Rulestext.text = "Toeic rules";
        }
        else if (save.Get_counter() == 4)
        {
            Titletext.text = "Concours Puissance Alpha";
            Rulestext.text = "Une affirmation vous est montrée.\n Dites si elle est VRAI ou FAUSSE.";
        }
    }



    /*public void StartGame()
	{
		UnityEngine.SceneManagement.SceneManager.LoadScene("Quizz", UnityEngine.SceneManagement.LoadSceneMode.Additive);
        //UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync("Menu_quizz");
    }*/
}