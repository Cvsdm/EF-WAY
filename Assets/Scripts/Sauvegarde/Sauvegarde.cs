using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using System;

public class Sauvegarde : MonoBehaviour {

    private int counter = 0;    //number of the tiles
    private string player_name;
    private int player_gender;  // 0 : masculin    1: Feminin

    private float jauge_assos = 0f;
    private float jauge_etude = 0f;
    private float jauge_sociabilité = 0f;

    private string fileName = "save_data.txt";
    private string path;
    
    private int[] Tab_assos = new int[3];
    private int majeur_choice = 0;
   // private highest score for each quizz ?

    void Start ()
    {
        if (Application.platform == RuntimePlatform.Android)
            path = Path.Combine(Application.persistentDataPath, fileName);
        else 
            path = Path.Combine(Application.streamingAssetsPath, fileName);

        DontDestroyOnLoad(gameObject); // do not destroy the sauvegarde while playing

        if (File.Exists(path) == false) // if there is no sauvegarde présente charge la scene de demande de prénom / gender
        {
            SceneManager.LoadScene("Identification");
        }
        else // if there is a sauvegarde / la chargé + bouger le pion + bouger les jauges, etc...
        {
            ChargefromFile();
            SceneManager.LoadScene("Jeu");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Save_Parameters ()
    {
        /*Debug.Log("bla save entered");
        Debug.Log("path : " + path);*/

        TextWriter writer = new StreamWriter(path); //create automaticcally file if not created

        writer.WriteLine(player_name);
        writer.WriteLine(player_gender);

        writer.WriteLine(jauge_assos);
        writer.WriteLine(jauge_etude);
        writer.WriteLine(jauge_sociabilité);

        writer.WriteLine(counter);
        writer.WriteLine(majeur_choice);

        writer.WriteLine(Tab_assos[0]);
        writer.WriteLine(Tab_assos[1]);
        writer.WriteLine(Tab_assos[2]);

        writer.Close();

    }

    void ChargefromFile()
    {
        StreamReader file = new StreamReader(path);

        player_name = file.ReadLine();
        player_gender = Int32.Parse(file.ReadLine());

        jauge_assos = Int32.Parse(file.ReadLine());
        jauge_etude = Int32.Parse(file.ReadLine());
        jauge_sociabilité = Int32.Parse(file.ReadLine());

        counter = Int32.Parse(file.ReadLine());
        majeur_choice = Int32.Parse(file.ReadLine());

        Tab_assos[0] = Int32.Parse(file.ReadLine());
        Tab_assos[1] = Int32.Parse(file.ReadLine());
        Tab_assos[2] = Int32.Parse(file.ReadLine());

        file.Close(); //close the stream
    }

    public void Set_player (string name)
    {
        player_name = name;
    }

    public void Set_gender(int genre)
    {
        player_gender = genre;
    }

    public float Get_etude() { return jauge_etude; }
    public float Get_assos() { return jauge_assos; }
    public float Get_sociabilite() { return jauge_sociabilité; }

    public void Set_etude(float nb) { jauge_etude = nb; }
    public void Set_assos(float nb) { jauge_assos = nb; }
    public void Set_sociabilite(float nb) { jauge_sociabilité = nb; }

    public void Add_assos(int newest)
    {

    }

    public void Set_majeure(int maj)
    {
        majeur_choice = maj;
    }

}
