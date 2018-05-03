using UnityEngine;

public class Quizz_data : MonoBehaviour
{
    public string filename;
    private Sauvegarde save;

    void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        
        switch (save.Get_counter())
        {
            case 4:
                filename = "data_concours.txt";
                break;

            case 19:
                if (save.Get_langue() == 0)
                    filename = "data_L1.txt";
                else
                    filename = "data_L1_E.txt";
                break;

            case 24:
                filename = "Projet_Voltaire.txt";
                break;

            case 34:
                if (save.Get_langue() == 0)
                    filename = "data_L1.txt";
                else
                    filename = "data_L1_E.txt";
                break;

            case 45:
                if (save.Get_langue() == 0)
                    filename = "data_L2.txt";
                else
                    filename = "data_L2_E.txt";
                break;

            case 51:
                if (save.Get_langue() == 0)
                    filename = "data_L3.txt";
                else
                    filename = "data_L3_E.txt";
                break;

            case 54:
                if (save.Get_langue() == 0)
                    filename = "data_L3.txt";
                else
                    filename = "data_L3_E.txt";
                break;


            case 63:
                if (save.Get_langue() == 0)
                    filename = "data_L3.txt";
                else
                    filename = "data_L3_E.txt";
                break;

            case 79:
                if (save.Get_langue() == 0)
                    filename = "data_M1.txt";
                else 
                    filename = "data_M1_E.txt";
                break;

            case 84:
                filename = "Projet_Voltaire.txt";
                break;

            case 91:
                filename = "TOEIC.txt";
                break;

            case 98:
                if (save.Get_langue() == 0)
                    filename = "data_M2.txt";
                else
                    filename = "data_M2_E.txt";
                break;


            default:
                filename = "data_concours.txt";
                break;
        }
    }
}
