using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Cases : MonoBehaviour
{

    private Sauvegarde save;
    private float add_jauge = 5f;
    public Text text;
    public Button button;
    public GameObject CaseDisplay;
    public Bars bars;

    void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        bars = FindObjectOfType<Bars>();

        if (save.Get_langue() == 0)
            button.GetComponentInChildren<Text>().text = "Continuer";
        else
            button.GetComponentInChildren<Text>().text = "Continue";
    }

    public void Case_action()
    {
        //Debug.Log("Je suis ds le bon script");
        CaseDisplay.SetActive(true);

        switch (save.Get_counter()) // switch le numéro de la case :) 
        {
            case 1:
                break;

            case 2:
                break;

            case 4:         // Concours entrée
                text.text = "Jour J !\nVous devez passer le concours Puissance Alpha !\nBon courage !";
                /// SceneManager.LoadScene(Quizz);
                break;

            case 10:        //POD d'intégration : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous participez au POD d'intégration et rencontrez de nombreuses personnes";
                else
                    text.text = "You take part in the integration POD and you meet lots of people";
                bars.DealSocialPlus(add_jauge);
                break;

            case 12:        //rally culturel : jauge sociabilité
                if (save.Get_langue() == 0)
                    text.text = "Vous participez au rally culturel organisé par l'équipe du WEI";
                else
                    text.text = "You take part in the cultural rally organized by the WEI team";
                bars.DealSocialPlus(add_jauge);
                break;

            case 13:        //soirée des parrains : jauge sociabilité
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez votre parrain lors de la soirée des parrains";
                else
                    text.text = "You meet your proposer during the proposer night";
                bars.DealSocialPlus(add_jauge);
                break;

            case 14:        // sèche les cours après la soirée des parrains : jauge étude diminue
                if (save.Get_langue() == 0)
                    text.text = "Vous vous êtes couché trop tard après la soirée des parrains et séchez le premier cours";
                else
                    text.text = "You went to sleep to late after the proposer night and don't go to the first class";
                bars.DealEtudeMinus(add_jauge);
                break;

            case 15:        //WEI : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous allez au week end d'intégration et rencontrez pleins d'étudiants";
                else
                    text.text = "You go to the integration week end and meet lots of people";
                bars.DealSocialPlus(add_jauge);
                break;

            case 16:        // Semaine des assos
                if (save.Get_langue() == 0)
                    text.text = "Semaine des assos\nVous pouvez choisir parmi toutes les associations 3 au maximum";
                else
                    text.text = "Association week\nYou may choose amongst all of them up to 3";
               /// SceneManager.LoadScene(4);          /// choix de 3 assos ? Script en plus ?
                break;

            case 17:        //1_assos
                if (save.Get_langue() == 0)
                    Action_Assos("EAH organise un petit déjeuner", "eah");
                else
                    Action_Assos("EAH organizes a breakfast", "eah");
                break;

            case 18:        //aide un ami en math : jauge étude
                if (save.Get_langue() == 0)
                    text.text = "Vous aidez un ami ayant des difficultés en math";
                else
                    text.text = "You help a friend having difficulties in mathematics";
                bars.DealEtudePlus(add_jauge);
                break;

            case 20:        // passe l'après midi en MDA : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous passez votre après-midi à la MDA et parlez avec beaucoup de personnes";
                else
                    text.text = "You spend your afternoon at the MDA and speak with lots of people";
                bars.DealSocialPlus(add_jauge);
                break;

            case 21:        // pas accepté en cours car + de 15 min de retard : jauge étude diminue
                if (save.Get_langue() == 0)
                    text.text = "Vous arrivez avec 15 minutes de retard et n'êtes pas accepté en cours";
                else
                    text.text = "you are 15 mintes late for your course and can't join the class";
                bars.DealEtudeMinus(add_jauge);
                break;

            case 22:        //2_assos
                if (save.Get_langue() == 0)
                    Action_Assos("Une soirée patinoire est organisée par Hock'Efrei", "Hock'Efrei");
                else
                    Action_Assos("Hock'Efrei organizes an outling to the ice rink", "Hock'Efrei");

                break;

            case 24:          // Projet Voltaire
                if (save.Get_langue() == 0)
                    text.text = "Projet Voltaire !\nVous devez réussir ce test de français niveau ingénieur pour recevoir votre diplôme... Bonne chance !";
                else
                    text.text = "Projet Voltaire !\nYou will need to pass with an engineer level this french test to get your diploma... Break a leg !";
                /// SceneManager.LoadScene(Quizz du Projet Voltaire);
                break;

            case 25:          //3_assos
                if (save.Get_langue() == 0)
                    Action_Assos("4eSport Efrei organise un tournoi", "4e sport");
                else
                    Action_Assos("4eSport Efrei organizes a tournament", "4e sport");
                break;

            case 27:          //4.1_assos
                // Show Ye'Misticrik, fait partie de l'assos (assos), sinon (social)
                if (save.Get_langue() == 0)
                    Action_Assos("Ye Mistikrik organise un spectacle avec des humoristes", "Ye Mistikrik");
                else
                    Action_Assos("Ye Mistikrik organizes a show gathering humorists", "Ye Mistikrik");
                break;

            case 32:          //4.2_assos
                // Mission EFFOR, jauge assos
                if (save.Get_langue() == 0)
                    Action_Assos("Mission EFFOR : vous aidez une entreprise à déménager", "EFFOR");
                else
                    Action_Assos("EFFOR Mission: you help for the move of a firm", "EFFOR");
                break;

            case 37:          //5_assos
                //Journée internationale, (social)
                if (save.Get_langue() == 0)
                    Action_Assos("C'est la journée internationale à l'Efrei Paris !", "Efrei international");
                else
                    Action_Assos("It's the international day at Efrei Paris!", "Efrei international");
                break;

            case 38:        //vous êtes élus délégué : jauge étude
                if (save.Get_langue() == 0)
                    text.text = "Vous êtes élu délégué de votre classe... félicitations !";
                else
                    text.text = "You have been elected as the new class representative... congratulation !";
                bars.DealEtudePlus(add_jauge);
                break;

            case 39:        //rencontre avec ton fillot : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez votre fillot pour la première fois !";
                else
                    text.text = "You meet for the time your protégé !";
                bars.DealSocialPlus(add_jauge);
                break;

            case 40:        //nouveau choix d'assos : jauge association qui augmente ou diminue
                if (save.Get_langue() == 0)
                    text.text = "Association: choississez de nouvelles assos ou quittez-en à votre guise !";
                else
                    text.text = "Association: Choose new associations or quit some if you want !";
                //appel vers la même fonction que celle du stop choix d'assos, modification des jauges dans la fonction direct

                break;

            case 42:            // Choix destination
                if (save.Get_langue() == 0)
                    text.text = "Vous partez au prochain semestre à l'étranger. Vous devez choisir votre destination !";
                else
                    text.text = "You will leave next semester abroad. You need to choose whether to leave alone or in a group and the location !";
                /// SceneManager.LoadScene(Choix destination);
                break;

            case 43:          //6_assos
                // Gala de l'Efrei, fait partie de l'assos (assos), sinon (social)
                if (save.Get_langue() == 0)
                    Action_Assos("C'est l'heure du Gala annuel de l'Efrei Paris !", "Gala");
                else
                    Action_Assos("It's time for the annual gala ball of Efrei Paris!", "Gala");
                break;

            case 44:        // vous effectué votre stage commercial : jauge étude
                if (save.Get_langue() == 0)
                    text.text = "Vous effectuez votre stage commercial d'un mois";
                else
                    text.text = "You do your commercial internship of one month";
                bars.DealEtudePlus(add_jauge);
                break;

            case 47:        // vous rencontrez vos nouveaux colocs : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez vos nouveaux colocs";
                else
                    text.text = "You meet your new housemates";
                bars.DealSocialPlus(add_jauge);
                break;
                

            case 49:          //7_assos
                // Vous participez à des activités sur le campus (social)
                if (save.Get_langue() == 0)
                    text.text = "Vous participez à des activités organisées sur le campus de votre université";
                else
                    text.text = "You take part in activities organized on the campus of your college";

                bars.DealSocialPlus(add_jauge);
                break;

            case 53:        // vous rencontrez des étudiants internationaux : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez des étudiants internationaux sur le campus";
                else
                    text.text = "You meet international students on the campus";

                bars.DealSocialPlus(add_jauge);
                break;

            case 57:          //8.1_assos
                //On vous propose de faire partie d'une liste BDE (assos) si 3 assos le joueur doit en supprimer 1
                if (save.Get_langue() == 0)
                    text.text = "Vous faite partie d'une liste BDE";
                else
                    text.text = "You take part in a list for the next student's association of Efrei Paris";

                save.Add_assos("BDE");
                bars.DealAssosPlus(add_jauge);

                break;

            case 59:        // Vous rêvez beaucoup de votre mobilité et vous impliquez moins dans votre travail : vos notes baisses, jauge étude diminue
                break;

            case 60:          //8.2_assos
                //Tournoi de la taverne, fait partie de l'assos (assos), sinon (social)
                if (save.Get_langue() == 0)
                    Action_Assos("La Taverne organise un tournoi", "Taverne");
                else
                    Action_Assos("The \"Taverne\" organizes a tournament", "Taverne");

                break;

            case 61:        // vous vantez auprès des L2 la destination que vous avez choisi : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous vantez auprès des L2 la destination que vous avez choisi pour votre mobilité";
                else
                    text.text = "You praise to second year's students the destination you choose for your mobility";

                bars.DealSocialPlus(add_jauge);
                break;

            case 62:            // Majeure
                if (save.Get_langue() == 0)
                    text.text = "C'est l'heure de choisir votre majeure !\nChoisissez bien";
                else
                    text.text = "It is time to choose your major !\nChoose carefully";
              ///  SceneManager.LoadScene(5);
                break;

            case 66:          //9_assos

                if (save.Get_langue() == 0)
                    Action_Assos("C'est L'I Week !", "I week");
                else
                    Action_Assos("It's 'I Week' time !", "I week");
                break;

            case 73:          //10_assos

                if (save.Get_langue() == 0)
                    Action_Assos("Le groupe Escape organise un Escape Game dans le métro de Paris", "Groupe Escape");
                else
                    Action_Assos("The Escape Group organizes an Escape Game in the Metro of Paris", "Groupe Escape");
                break;

            case 78:          //11_assos

                if (save.Get_langue() == 0)
                    Action_Assos("Efrei Microsoft organise une formation pour en savoir plus sur certains logiciels", "Microsoft");
                else
                    Action_Assos("Efrei Microsoft organizes a course training to learn more about some softwares", "Microsoft");
                break;

            case 83:          //PV
                if (save.Get_langue() == 0)
                    text.text = "Projet Voltaire !\nEt oui, il faut le repasser... Bonne chance !";
                else
                    text.text = "Projet Voltaire !\nYes, you will need to do it again... Break a leg !";
                /// SceneManager.LoadScene(Quizz du Projet Voltaire);
                break;

            case 84:          //12_assos

                if (save.Get_langue() == 0)
                    Action_Assos("EPS organise une formation pour apprendre à se servir d'un reflexe", "EPS");
                else
                    Action_Assos("EPS organizes a training course to learn how to use a reflex camera", "EPS");
                break;

            case 85:          //13_assos

                if (save.Get_langue() == 0)
                    Action_Assos("La Sepefrei organise un petit déjeuner spécial recrutement", "Sepefrei");
                else
                    Action_Assos("Sepefrei organizes a breakfast in a hiring purpose", "Sepefrei");
                break;

            case 90:          //TOEIC
                if (save.Get_langue() == 0)
                    text.text = "C'est le TOEIC ! Epreuve d'anglais indispensable pour les futurs ingénieurs";
                else
                    text.text = "TOEIC time ! English test essential to futur engineers";
                /// SceneManager.LoadScene(Quizz du TOEIC);
                break;

            case 91:          //14_assos

                if (save.Get_langue() == 0)
                    Action_Assos("L'AI Efrei organise un afterwork entre étudiants actuels et anciens de l'Efrei Paris", "AI efrei");
                else
                    Action_Assos("AI Efrei organizes an afterwork with current and former students of Efrei Paris", "AI efrei");
                break;

            case 96:          //15_assos

                if (save.Get_langue() == 0)
                    Action_Assos("L'Asian Efrei organise l'Aki Party !", "Asian");
                else
                    Action_Assos("Asian Efrei organizes The Aki Party !", "Asian");
                break;

            case 100:           //Remise des diplômes
                if (save.Get_langue() == 0)
                    text.text = "Félicitations ! Vous avez réussi !\nVous venez de recevoir votre diplôme d'ingénieur de EF'WAY !";
                else
                    text.text = "Congratulations ! You did it !\nYou have been awarded your very own EF'WAY diploma !";
                break;

        }
    }

    public void Action_Assos(string action, string assos_Name)
    {
        text.text = action;

        if (save.Found_assos(assos_Name)) //fait partie de l'assos
            bars.DealAssosPlus(add_jauge);
        else
            bars.DealSocialPlus(add_jauge);

    }

    public void Action_button()
    {
        save.Save_Parameters();
        int i = save.Get_counter();
        CaseDisplay.SetActive(false);

        if (i == 4 || i == 24 || i == 90 || i == 83) // lancer scène quizz
            SceneManager.LoadScene("Persistent_quizz");
        else if (i == 16) // lancer scène assos
            SceneManager.LoadScene("Menu Assos");
        else if(i == 62) // lancer les majeurs
            SceneManager.LoadScene("Choix des majeurs");
        //else if (i == 42) // lancer la scène de choix des destination
            //SceneManager.LoadScene("Choix destination");
        else
            StartCoroutine(save.Lancer_scene_dés());
    }


}
