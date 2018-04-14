using UnityEngine;

public class Quizz_data : MonoBehaviour
{
    public string[] filename = new string[1];

    void Start ()
    {
        filename[0] =  "data_concours.txt";
        //filename[1] =  "data_L1.txt";
        //SceneManager.LoadScene("Persistent");
    }

}
