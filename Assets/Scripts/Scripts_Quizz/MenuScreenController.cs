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

        if (save.Get_counter() == 24 || save.Get_counter() == 84)
        {
            Titletext.text = "Projet Voltaire";
            Rulestext.text = "Une phrase vous est affichée.\n Répondez VRAI si elle contient une faute.\n Répondez FAUX si elle ne contient PAS de faute.";
        }
        else if (save.Get_counter() == 91)
        {
            Titletext.text = "TOEIC";
            Rulestext.text = "Toeic rules";
        }
        else
        {
            if (save.Get_counter() == 4)
                Titletext.text = "Concours Puissance Alpha";
            else if (save.Get_counter() == 19)
                Titletext.text = "CE L1";
            else if (save.Get_counter() == 34)
                Titletext.text = "DE L1";
            else if (save.Get_counter() == 45)
                Titletext.text = "DE L2";
            else if (save.Get_counter() == 51)
                Titletext.text = "CE L3";
            else if (save.Get_counter() == 54)
                Titletext.text = "CE L3";
            else if (save.Get_counter() == 63)
                Titletext.text = "DE L3";
            else if (save.Get_counter() == 79)
                Titletext.text = "DE M1";
            else if (save.Get_counter() == 98)
                Titletext.text = "DE M2";

            if (save.Get_langue() == 0)
                Rulestext.text = "Une affirmation vous est montrée.\n Dites si elle est VRAI ou FAUSSE.";
            else
                Rulestext.text = "An affirmation is shown.\n Indicate if it is TRUE or FALSE.";
        }
    }
}