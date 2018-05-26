using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Canvas question_mark;
    public GameObject lex;
    private Sauvegarde save;
    public Text btn_throw, btn_continue, text_lex;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        Toogle_lex();
    }

    public void Toggle_canvas()
    {
        if (!question_mark.gameObject.activeSelf)
            question_mark.gameObject.SetActive(true);
        else
            question_mark.gameObject.SetActive(false);
    }

    public void Throw_Dice()
    {
        GameObject.Find("Dés").SetActive(false);
        StartCoroutine(save.Load_scenes(0.8f));
    }

    public void Modify_dice()
    {
        btn_throw.text = "Throw dices";
        btn_continue.text = "Continue";
        Toogle_lex();
    }

    public void On_Lexique()
    {
        question_mark.gameObject.SetActive(false);
        lex.gameObject.SetActive(true);
        Movement.isRunning = true;
    }

    public void Off_Lexique()
    {
        lex.gameObject.SetActive(false);
        Movement.isRunning = false;
    }

    public void Toogle_lex ()
    {
        if (save.Get_langue() == 0)
        {
            text_lex.text = "Lexique:" +
                "\n\nWEI: Week - end d'intégration" +
                "\n\nPOD: Soirée étudiante " +
                "\n\nRezal: Venez jouer aux jeux vidéos toute la nuit, au programme: Lol, Overwatch, Team Fortress et bien d'autres..." +
                "\n\nAkii Partie : Venez découvrir la culture asiatique lors d'un événement nocturne organisé par Asian Efrei. Au programme : Karaoké, jeux traditionnels, origami..." +
                "\n\nInternational Day : Une journée dédiée à la culture des différents pays.\n" +
                "\n\nBDE : Bureau des étudiants" +
                "\n\nPFE : Projet de fin d'études" +
                "\n\nIweek : Semaine d'accueil d'étrangers à l'EFREI. Faire découvrir et visiter Paris." +
                "\n\nFab lab : Laboratoire de fabrication" +
                "\n\nTalent day : Forum des entreprises à l'EFREI." +
                "\n\nInnovation day : Journée des projets étudiants" +
                "\n\nPrintemps des entrepreneurs : Recueil d'avis de professionnels sur des projets d'entreuprenariats des étudiants.";
        }
        else
        {
            text_lex.text = "Lexique:" +
            "\n\nWEI: Intégration Weekend" +
            "\n\nPOD: Student Party" +
            "\n\nRezal: Come play video games all night, on the program: LoL, Overwatch, Team Fortress and many more ..." +
            "\n\nAkii Partie : Come and discover Asian culture at a night event organized by Asian Efrei, featuring Karaoke, traditional games, origami ..." +
            "\n\nInternational Day : A day dedicated to the culture of foreign countries. " +
            "\n\nBDE : Student Services Office" +
            "\n\nPFE : End of study project" +
            "\n\nIweek : Welcome week for foreigners at EFREI. Discovery and visit of Paris for the foreigners students." +
            "\n\nFab lab : Fabrication laboratory" +
            "\n\nTalent day : Fair of companies at EFREI." +
            "\n\nInnovation day : day of presentation of student's project" +
            "\n\nPrintemps des entrepreneurs : A collection of professional opinions on student entrepreneurship projects.";
        }
    }


}
