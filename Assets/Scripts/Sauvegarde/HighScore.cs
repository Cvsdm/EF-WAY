using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class HighScore : MonoBehaviour {

    private float HighestScore = 0;
    private int NbGamePlayed = 0;
    private Sauvegarde save;
    public Text text;
    private string fileName = "statistics.txt";
    private string path;

    void Start () {
        save = FindObjectOfType<Sauvegarde>();
        if (Application.platform == RuntimePlatform.Android)
            path = Path.Combine(Application.persistentDataPath, fileName);
        else
            path = Path.Combine(Application.streamingAssetsPath, fileName);
        if (File.Exists(path) == false) { Save_Highest(); }
        else  {  ChargefromFile(); }
        NbGamePlayed ++;
        float now = save.Get_assos() + 2*save.Get_etude() + save.Get_sociabilite();

        if (save.Get_langue() == 0)
            text.text = " Statistics : \n\n\n ";
        else
            text.text = " Statistiques : \n\n\n ";

        if (now > HighestScore)
        {
            HighestScore = now;
            if (save.Get_langue() == 0)
                text.text = text.text + " Félicitations ! Tu as battu ton meilleur score :D \n";
            else 
            text.text = text.text +  " Congratulations ! You've beated your Highest Score :D \n";
        }

        Display_text();
	}

    void Display_text()
    {
        if (save.Get_langue() == 0)
            text.text = text.text + "\nHighest Score " + HighestScore + "\n\n Number of Game played : " + NbGamePlayed;
        else
            text.text = text.text + "\nMeilleur Score " + HighestScore + "\n\n Nombre de parties jouées : " + NbGamePlayed;
    }

    public void Save_Highest()
    {
        TextWriter writer = new StreamWriter(path); //create automatically file if not created
        writer.WriteLine(HighestScore);
        writer.WriteLine(NbGamePlayed);
        writer.Close();
    }

    void ChargefromFile()
    {
        StreamReader file = new StreamReader(path);
        HighestScore = Int32.Parse(file.ReadLine());
        NbGamePlayed = Int32.Parse(file.ReadLine());
        file.Close(); //close the stream
    }

}
