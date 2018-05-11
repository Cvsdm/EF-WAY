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
        

        //Debug.Log("langue " + langue);
        
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
                save.Set_imm(true);
                break;

            case 2:
                choixDestination = "USA - Stony Brook University";
                save.Set_imm(true);
                break;

            case 3:
                choixDestination = "USA - Harrisburg University";
                save.Set_imm(true);
                break;

            case 4:
                choixDestination = "Singapore - Nanyang University";
                save.Set_imm(true);
                break;

            case 5:
                choixDestination = "Australia - Curtin University";
                save.Set_imm(true);
                break;

            case 6:
                choixDestination = "Sweden - Linkoping University";
                save.Set_imm(true);
                break;

            case 7:
                choixDestination = "Sweden - Linnaeus University";
                save.Set_imm(true);
                break;

            case 8:
                choixDestination = "England - Coventry University";
                save.Set_imm(true);
                break;

            case 9:
                choixDestination = "Angleterre - Staffordhire University";
                save.Set_imm(true);
                break;

            case 10:
                choixDestination = "Pologne - AGH University";
                save.Set_imm(false);
                break;

            case 11:
                choixDestination = "Canada - Concordia University";
                save.Set_imm(false);
                break;

            case 12:
                choixDestination = "Inde - Manipal University";
                save.Set_imm(false);
                break;

            case 13:
                choixDestination = "Malaisie - Asia Pacific University";
                save.Set_imm(false);
                break;

            case 14:
                choixDestination = "Afrique du Sud - Cape Peninsula University";
                save.Set_imm(false);
                break;
        }

        save.Set_destination(choixDestination);
        save.Save_Parameters();
        save.Disp_after_Stop("Menu Destinations");
    }

    public void Exit_button()
    {
        save.Disp_after_Stop("Menu Destinations");
    }
}
