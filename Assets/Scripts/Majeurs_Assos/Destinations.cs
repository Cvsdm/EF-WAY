using UnityEngine;

public class Destinations : MonoBehaviour
{
    public GameObject choix;
    public GameObject seul;
    public GameObject encadre;
    public GameObject returnBtn;

    string choixDestination;

    private int langue;
    private Sauvegarde save;

    public void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        langue = save.Get_langue();

        choix.SetActive(false);
        seul.SetActive(false);
        encadre.SetActive(false);
        

        Debug.Log("langue " + langue);
        
        if (langue == 0)
        {
            encadre.SetActive(true);
            returnBtn.SetActive(false);
        }
        else if (langue == 1)
        {
            choix.SetActive(true);
        }
    }


    public void ToggleChoix()    //toggle on or off the pause menu
    {
        choix.SetActive(!choix.activeSelf);
    }

    public void ToggleSeul()
    {
        seul.SetActive(!seul.activeSelf);
    }

    public void ToggleEncadre()
    {
        encadre.SetActive(!encadre.activeSelf);
    }

    

    public void Choice(int temp)
    {
        switch (temp)
        {
            case 1:
                choixDestination = "Mexico - ITESM Capus Mexico";
                break;

            case 2:
                choixDestination = "USA - Stony Brook University";
                break;

            case 3:
                choixDestination = "USA - Harrisburg University";
                break;

            case 4:
                choixDestination = "Singapore - Nanyang University";
                break;

            case 5:
                choixDestination = "Australia - Curtin University";
                break;

            case 6:
                choixDestination = "Sweden - Linkoping University";
                break;

            case 7:
                choixDestination = "Sweden - Linnaeus University";
                break;

            case 8:
                choixDestination = "England - Coventry University";
                break;

            case 9:
                choixDestination = "Angleterre - Staffordhire University";
                break;

            case 10:
                choixDestination = "Pologne - AGH University";
                break;

            case 11:
                choixDestination = "Canada - Concordia University";
                break;

            case 12:
                choixDestination = "Inde - Manipal University";
                break;

            case 13:
                choixDestination = "Malaisie - Asia Pacific University";
                break;

            case 14:
                choixDestination = "Afrique du Sud - Cape Peninsula University";
                break;
        }

        save.Set_destination(choixDestination);
        save.Save_Parameters();

    }
}
