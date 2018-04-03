using UnityEngine;
using System.IO;
using System;


public class Database : MonoBehaviour
{
    public QuestionData[] allquestions = new QuestionData[14];
    //private string gameDataFileName = "data.db";
    private string gameDataFileName = "data_concours.txt";

    void Start()
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);

        int counter = 0;
        string line;

        // Read the file and display it line by line.  
        System.IO.StreamReader file = new System.IO.StreamReader(filePath);
        while ((line = file.ReadLine()) != null)
        {
            //Debug.Log(line);
            allquestions[counter].questionText = line;

            line = file.ReadLine();
            //Debug.Log(Int32.Parse(line));
            if (Int32.Parse(line) == 1)
                allquestions[counter].isTrue = true;
            else
                allquestions[counter].isTrue = false;
            counter++;
        }

        Debug.Log("nb of line : " + counter);
    }
}


