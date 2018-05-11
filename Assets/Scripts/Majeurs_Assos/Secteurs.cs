using UnityEngine;

public class Secteurs : MonoBehaviour
{

    string choixSecteur;
    
    private Sauvegarde save;

    public void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
    }

    public void Choice(int temp)
    {
        switch (temp)
        {
            case 1:
                choixSecteur = "Ingénieur d'Affaires";
                break;

            case 2:
                choixSecteur = "Entrepreneur";
                break;

            case 3:
                choixSecteur = "International Project Manager";
                break;

            case 4:
                choixSecteur = "Consultant";
                break;

            case 5:
                choixSecteur = "Innovation and Strategy";
                break;

            case 6:
                choixSecteur = "Expert";
                break;

            case 7:
                choixSecteur = "Research and Development";
                break;

        }

        save.Set_secteur(choixSecteur);
        save.Save_Parameters();
        save.Disp_after_Stop("Menu-Secteurs");
    }

    public void Exit_button()
    {
        save.Disp_after_Stop("Menu-Secteurs");
    }
}
