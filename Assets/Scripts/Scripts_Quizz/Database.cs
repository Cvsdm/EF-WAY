using UnityEngine;
using System.IO;
using System;

public class Database : MonoBehaviour
{
    public QuestionData[] allquestions = new QuestionData[14];
   // private string gameDataFileName;// = "data_concours.txt";

    public void Create_Database(string gameDataFileName)
    {
        string originalPath = Path.Combine(Application.streamingAssetsPath, gameDataFileName);
        string databasePath = originalPath;
        int counter = 0;
        string line;

        if (Application.platform == RuntimePlatform.Android)
        {
            WWW reader = new WWW(originalPath); // Android only use WWW to read file
            while (!reader.isDone) { }

            string realPath = Application.persistentDataPath + "/db";
            File.WriteAllBytes(realPath, reader.bytes);

            databasePath = realPath;
        }

        StreamReader file = new StreamReader(databasePath);
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
        file.Close(); //close the stream

        if (Application.platform == RuntimePlatform.Android)
        {
            File.Delete(databasePath); //delete the created file
        }

    }
}


