using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class Sauvegarde : MonoBehaviour {

    private int counter = 0;    //number of the tiles
    private string player_name;
    private int player_gender;  // 0 : masculin    1: Feminin

    private float jauge_assos = 0f;
    private float jauge_etude = 0f;
    private float jauge_sociabilité = 0f;

    private string fileName = "save_data.txt";
    private string path;

    private string[] Tab_assos = new string[3] { "none", "none", "none" };
    private int majeur_choice = 0;
    private int nextmove = 0;
    private int langue = 0; //french
    private int nb_jetons = 0;
    private string destination = "destination";

    public GameObject canvas_resume;

    private GameObject terrain;
    private GameObject canvas_jeu;
    private GameObject jauges;
    //private GameObject canvas_resume;


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
            canvas_resume.SetActive(true);
        }
	}

    // Update is called once per frame
    //void Update() { }

    public void Save_Parameters ()
    {
        TextWriter writer = new StreamWriter(path); //create automaticcally file if not created

        writer.WriteLine(player_name);
        writer.WriteLine(player_gender);

        writer.WriteLine(jauge_assos);
        writer.WriteLine(jauge_etude);
        writer.WriteLine(jauge_sociabilité);

        writer.WriteLine(counter);
        writer.WriteLine(nb_jetons);
        writer.WriteLine(majeur_choice);
        writer.WriteLine(destination);

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
        nb_jetons = Int32.Parse(file.ReadLine());
        majeur_choice = Int32.Parse(file.ReadLine());
        destination = file.ReadLine();

        Tab_assos[0] = file.ReadLine();
        Tab_assos[1] = file.ReadLine();
        Tab_assos[2] = file.ReadLine();

        file.Close(); //close the stream
    }

    public float    Get_etude()        { return jauge_etude; }
    public float    Get_assos()        { return jauge_assos; }
    public float    Get_sociabilite()  { return jauge_sociabilité; }
    public int      Get_counter()      { return counter; }
    public int      Get_nextmove()     { return nextmove; }
    public int      Get_langue()       { return langue; }
    public int      Get_jetons()       { return nb_jetons; }
    public string   Get_Tab_assos(int i)   { return Tab_assos[i]; }
    public string   Get_destination()  { return destination; }

    public void Set_player(string name)             { player_name = name; }
    public void Set_gender(int genre)               { player_gender = genre; }
    public void Set_etude(float nb)                 { jauge_etude = nb; }
    public void Set_assos(float nb)                 { jauge_assos = nb; }
    public void Set_sociabilite(float nb)           { jauge_sociabilité = nb; }
    public void Set_majeure(int maj)                { majeur_choice = maj; }
    public void Set_counter(int count)              { counter = count; }
    public void Set_nextmove(int move)              { nextmove = move; }
    public void Set_jetons(int jeton)               { nb_jetons = jeton; }
    public void Set_Tab_assos(int i,string assos)   { Tab_assos[i] = assos; }
    public void Set_destination(string choixDestination) { destination = choixDestination; }



    public void Add_assos(string newest)
    {
        int i = 0, flag = -1;

        //Debug.Log("add assos");
        while ( i < Tab_assos.Length && flag == -1) //find where to put it
        {
            if (Tab_assos[i].Equals("none"))
                flag = i;
            i++;
        }
        //Debug.Log("flag : " + flag );

        if (flag == -1)// have to delete and replace a assos
        {
            //FindObjectOfType<Gerer_Assos>().canvas_suppress.SetActive(true);
            //FindObjectOfType<Gerer_Assos>().canvas.SetActive(false);
            FindObjectOfType<Gerer_Assos>().Initialize();
        }
        else
        {
            Tab_assos[flag] = newest;
            Debug.Log("Tab_assos[" + flag + "] = " + newest);
        }
    }

    public void Display_attributes()
    {
        Debug.Log("counter : " + counter);
        Debug.Log("jauge_assos : " + jauge_assos);
        Debug.Log("jauge_etudes : " + jauge_etude);
        Debug.Log("jauge_social : " + jauge_sociabilité);
        Debug.Log("nextmove : " + nextmove);
        Debug.Log("majeure : " + majeur_choice);
    }

    public bool Found_assos(string tofind)
    {
        for (int i = 0; i < Tab_assos.Length; i++)
        {
            if (Tab_assos[i].Equals(tofind))
                return true;
        }

        return false;
    }

    /*public IEnumerator Lancer_scene_dés()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Lancé de dés", LoadSceneMode.Additive);
    }*/

    public void Button_yes()
    {
        ChargefromFile();
        SceneManager.LoadScene("Jeu");
    }

    public void Button_no()
    {
        File.Delete(path);
        SceneManager.LoadScene("Identification");
    }

    public void Disp_Dice()
    {
        terrain = GameObject.Find("Terrain");
        terrain.gameObject.SetActive(false);
        jauges = GameObject.Find("Jauges");
        jauges.gameObject.SetActive(false);
        canvas_jeu = GameObject.Find("Canvas_Jeu");
        canvas_jeu.gameObject.SetActive(false);
    }

    /*public IEnumerator Load_scenes(float waitTime)
    {
        Disp_Dice();
        //SceneManager.LoadScene("lancé de dés", LoadSceneMode.Additive);
        var loading = SceneManager.LoadSceneAsync("lancé de dés", LoadSceneMode.Additive);
        yield return loading;
        var scene = SceneManager.GetSceneByName("lancé de dés");
        SceneManager.SetActiveScene(scene);
    }*/

    /*public IEnumerator Load_scenes(float waitTime)
    {
        Disp_Dice();
        
        yield return waitTime;

        SceneManager.LoadScene("lancé de dés", LoadSceneMode.Additive);

    }*/

    public IEnumerator Load_scenes(float waitTime)
    {
        Disp_Dice();

        if (waitTime == 0)
        {
            var loading = SceneManager.LoadSceneAsync("lancé de dés", LoadSceneMode.Additive);
            yield return loading;
            var scene = SceneManager.GetSceneByName("lancé de dés");
            SceneManager.SetActiveScene(scene);
        }
        else
        {
            yield return waitTime;
            SceneManager.LoadScene("lancé de dés", LoadSceneMode.Additive);
        }

    }

    public void Disp_game()
    {
        /*GameObject.Find("Terrain").gameObject.SetActive(true);
        GameObject.Find("Jauges").gameObject.SetActive(true);
        GameObject.Find("Canvas_Jeu").gameObject.SetActive(true);*/
        terrain.gameObject.SetActive(true);
        jauges.gameObject.SetActive(true);
        canvas_jeu.gameObject.SetActive(true);
        SceneManager.UnloadSceneAsync("lancé de dés");
        if (counter == 0)
            Movement.Play_iTween(GameObject.Find("Sphere_path")); 
        else
            iTween.Resume();
        //start movement
    }
}
