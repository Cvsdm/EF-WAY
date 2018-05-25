using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;
using System;
using System.Collections;

public class Sauvegarde : MonoBehaviour
{

    private int counter = 0;    //number of the tiles
    private string player_name;
    private int bac;  // 0 : s    1: es sti2d

    private float jauge_assos = 0f;
    private float jauge_etude = 0f;
    private float jauge_sociabilité = 0f;

    private string fileName = "save_data.txt";
    private string path;

    private string[] Tab_assos = new string[3] { "none", "none", "none" };
    private string majeur_choice = "majeure";
    private int nextmove = 0;
    private int langue = 0; //french
    private int nb_jetons = 0;
    private string destination = "destination";
    private string section = "section";
    private bool imm = false;
    private bool bde = false;
    private string secteur = "secteur";

    public GameObject canvas_resume;
    private GameObject terrain;
    private GameObject canvas_jeu;
    private GameObject jauges;
    private GameObject pawn;
    public static GameObject dices;

    void Start()
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

    public void Save_Parameters()
    {
        TextWriter writer = new StreamWriter(path); //create automatically file if not created

        writer.WriteLine(player_name);
        writer.WriteLine(bac);

        writer.WriteLine(jauge_assos);
        writer.WriteLine(jauge_etude);
        writer.WriteLine(jauge_sociabilité);

        writer.WriteLine(langue);
        writer.WriteLine(counter);
        writer.WriteLine(nb_jetons);
        writer.WriteLine(majeur_choice);
        writer.WriteLine(destination);
        writer.WriteLine(section);
        writer.WriteLine(imm);
        writer.WriteLine(bde);
        writer.WriteLine(secteur);

        writer.WriteLine(Tab_assos[0]);
        writer.WriteLine(Tab_assos[1]);
        writer.WriteLine(Tab_assos[2]);

        writer.Close();
    }

    void ChargefromFile()
    {
        StreamReader file = new StreamReader(path);

        player_name = file.ReadLine();
        bac = Int32.Parse(file.ReadLine());

        jauge_assos = Int32.Parse(file.ReadLine());
        jauge_etude = Int32.Parse(file.ReadLine());
        jauge_sociabilité = Int32.Parse(file.ReadLine());

        langue = Int32.Parse(file.ReadLine());
        counter = Int32.Parse(file.ReadLine());
        nb_jetons = Int32.Parse(file.ReadLine());
        majeur_choice = file.ReadLine();
        destination = file.ReadLine();
        section = file.ReadLine();
        imm = Boolean.Parse(file.ReadLine());
        bde = Boolean.Parse(file.ReadLine());
        secteur = file.ReadLine();

        Tab_assos[0] = file.ReadLine();
        Tab_assos[1] = file.ReadLine();
        Tab_assos[2] = file.ReadLine();

        file.Close(); //close the stream
    }

    public string Get_player() { return player_name; }
    public float Get_etude() { return jauge_etude; }
    public float Get_assos() { return jauge_assos; }
    public float Get_sociabilite() { return jauge_sociabilité; }
    public int Get_counter() { return counter; }
    public int Get_nextmove() { return nextmove; }
    public int Get_langue() { return langue; }
    public int Get_jetons() { return nb_jetons; }
    public string Get_Tab_assos(int i) { return Tab_assos[i]; }
    public string Get_destination() { return destination; }
    public string Get_section() { return section; }
    public int Get_bac() { return bac; }
    public bool Get_imm() { return imm; }
    public bool Get_bde() { return bde; }
    public string Get_majeure() { return majeur_choice; }
    public string Get_secteur() { return secteur; }
    public string Get_path() { return path; }

    public void Set_player(string name) { player_name = name; }
    public void Set_bac(int genre) { bac = genre; }
    public void Set_etude(float nb) { jauge_etude = nb; }
    public void Set_assos(float nb) { jauge_assos = nb; }
    public void Set_sociabilite(float nb) { jauge_sociabilité = nb; }
    public void Set_majeure(string maj) { majeur_choice = maj; }
    public void Set_counter(int count) { counter = count; }
    public void Set_nextmove(int move) { nextmove = move; }
    public void Set_jetons(int jeton) { nb_jetons = jeton; }
    public void Set_Tab_assos(int i, string assos) { Tab_assos[i] = assos; }
    public void Set_destination(string choixDestination) { destination = choixDestination; }
    public void Set_section(string choixSection) { section = choixSection; }
    public void Set_langue(int langage) { langue = langage; }
    public void Set_imm (bool im) { imm = im; }
    public void Set_secteur(string sect) { secteur = sect; }
    public void Set_bde(bool bd) { bde = bd; }



    public void Add_assos(string newest)
    {
        int i = 0, flag = -1;

        while (i < Tab_assos.Length && flag == -1) //find where to put it
        {
            if (Tab_assos[i].Equals("none"))
                flag = i;
            i++;
        }

        if (flag == -1)// have to delete and replace a assos
        {
            FindObjectOfType<Gerer_Assos>().Initialize();
            FindObjectOfType<Bars>().DealAssosMinus(20f);
        }
        else
        {
            Tab_assos[flag] = newest;
            FindObjectOfType<Bars>().DealAssosPlus(20f);
        }

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
        terrain.gameObject.SetActive(false);
        jauges.gameObject.SetActive(false);
        canvas_jeu.gameObject.SetActive(false);
        pawn.gameObject.SetActive(false);
    }

    public IEnumerator Load_scenes(float waitTime)
    {
        yield return new WaitForSecondsRealtime(waitTime);
        SceneManager.LoadScene("lancé de dés", LoadSceneMode.Additive);
        Disp_Dice();
    }

    public void Disp_game()
    {
        terrain.gameObject.SetActive(true);
        jauges.gameObject.SetActive(true);
        canvas_jeu.gameObject.SetActive(true);
        pawn.gameObject.SetActive(true);
        SceneManager.UnloadSceneAsync("lancé de dés");

        if (nextmove == 0)
            dices.SetActive(true);

        else if (counter == 0)
            Movement.Play_iTween(GameObject.Find("Sphere_path"));
        else
        {
            if (IsIntersection())
            {
                if (counter != 46) // si ce n'est pas la case immersion
                    StartCoroutine(FindObjectOfType<Triggered>().Choice());
                else
                {
                    if (imm)
                        Movement.pathname = "J1_" + Movement.path_counter + "_LEFT";
                    else
                    {
                        Movement.pathname = "J1_" + Movement.path_counter + "_RIGHT";
                        FindObjectOfType<Triggered>().Move_counter();
                    }

                    Movement.Play_iTween(GameObject.Find("Sphere_path"));
                }
            }
            else
            {
                if (Movement.flag == true)
                    Movement.Play_iTween(GameObject.Find("Sphere_path"));
                else
                    iTween.Resume();
            }   
        }
    }

    public void Find_dice ()
    {
        dices = GameObject.Find("Dés");
        terrain = GameObject.Find("Terrain");
        jauges = GameObject.Find("Jauges");
        canvas_jeu = GameObject.Find("Canvas_Jeu");
        pawn = GameObject.Find("pion");
    }

    public void Disp_after_Stop(string scene)
    {
        SceneManager.UnloadSceneAsync(scene);
        Movement.isRunning = false;

        if (nextmove == 0)
            dices.SetActive(true);
        else { iTween.Resume(); }
    }

    public bool IsIntersection()
    {
        bool res = false;
        if (counter == 8 ||
            counter == 25 ||
            counter == 46 ||
            counter == 56)
            res = true;

        return res;
    }
}
