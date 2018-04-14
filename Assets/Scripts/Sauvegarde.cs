using UnityEngine;

public class Sauvegarde : MonoBehaviour {

    private int counter; //number of the tiles
    private string player_name;
    private int player_gender; 

    private int jauge_assos;
    private int jauge_etude;
    private int jauge_sociabilité;

    private string fileName = "save_data.txt";

   // private int[3] Tab_assos;
   // private int majeur_choice;
   // private highest score for each quizz ?



    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(gameObject); // do not destroy the sauvegarde while playing
		/*
         if (fileName == NULL)
            lancer la scène d'enregistrement qui lance le save parameters..
         if there is no sauvegarde présente charge la scene de demande de prénom / gender
         if there is a sauvegarde / la chargé + bouger le pion + bouger les jauges, etc...
         */
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void Save_Parameters ()
    {

    }
}
