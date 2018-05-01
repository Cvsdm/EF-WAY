using UnityEngine;

public class Quizz_data : MonoBehaviour
{
    public string filename;
    private Sauvegarde save;

    void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        Debug.Log(save.Get_counter());

        switch (save.Get_counter())
        {
            case 4:
                filename = "data_concours.txt";
                break;
            case 90:
                filename = "TOEIC.txt"; ;
                break;
            case 24:
                filename = "Projet_Voltaire.txt";
                break;
            case 83:
                filename = "Projet_Voltaire.txt";
                break;
            default:
                filename = "data_concours.txt";
                break;


                /*case 1:
                 * if (save.Get_langue() == 0)
                    filename = "data_L1.txt";
                    else 
                    filename = "data_L1_E.txt";
            break;
        case 1:
                             * if (save.Get_langue() == 0)
                    filename = "data_L2.txt";
                    else 
                    filename = "data_L2_E.txt";
            break;
        case 1:
                             * if (save.Get_langue() == 0)
                    filename = "data_L3.txt";
                    else 
                    filename = "data_L3_E.txt";
            break;
        case 1:
                             * if (save.Get_langue() == 0)
                    filename = "data_M1.txt";
                    else 
                    filename = "data_M1_E.txt";
            break;
        case 1:
                            * if (save.Get_langue() == 0)
                    filename = "data_M2.txt";
                    else 
                    filename = "data_M2_E.txt";
            break;*/
        }
    }
}
