using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//using System;
using System.Collections;

public class Cases : MonoBehaviour
{
    private Sauvegarde save;
    private float add_jauge = 10f;
    public Text text;
    public Button button, btn1_dilemme, btn2_dilemme;
    public GameObject CaseDisplay;
    public Bars bars;

    void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        bars = FindObjectOfType<Bars>();
        StartCoroutine(save.Load_scenes());

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
                if (save.Get_langue() == 0)
                    text.text = "Rendez-vous d'orientation\n Vous avez gagné un jeton !";
                else
                    text.text = "Appointment for your course choice\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 2:
                if (save.Get_langue() == 0)
                    text.text = "C'est la journée Projette-toi !\n Vous avez gagné un jeton !";
                else
                    text.text = "it's the immersion day !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 4:         // Concours entrée
                text.text = "Jour J !\nVous devez passer le concours Puissance Alpha !\nBon courage !";
                /// SceneManager.LoadScene(Quizz);
                break;

            case 5:
                if (save.Get_langue() == 0)
                    text.text = "Vous avez participé à la Journée Portes Ouvertes !\n Vous avez gagné un jeton !";
                else
                    text.text = "You have participated at the open day !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 6:
                if (save.Get_langue() == 0)
                    text.text = "Vous avez participé à l'événement : Passe mon bac !\n Vous avez gagné un jeton !";
                else
                    text.text = "You have participated at the event : Get your high school diploma !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 7:
                if (save.Get_langue() == 0)
                    text.text = "Vous avez eu votre bac !\n Vous avez gagné un jeton !";
                else
                    text.text = "You have got your high school diploma\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 8:
                if (save.Get_langue() == 0)
                    text.text = "C'est la rentrée !\n Vous avez gagné un jeton !";
                else
                    text.text = "It's your first day at EFREI !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 9:
                if (save.Get_langue() == 0)
                    text.text = "Vous avez assisté à votre premier cours !\n Vous avez gagné un jeton !";
                else
                    text.text = "You've attended your first course !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 11: //???
                if (save.Get_langue() == 0)
                    text.text = "Vous avez participé à l'évènement : Sidaction !\n Vous avez gagné un jeton !";
                else
                    text.text = "You've participated at the event : Sidaction !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 10:        //POD d'intégration : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous participez au POD d'intégration et rencontrez de nombreuses personnes\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You take part in the integration POD and you meet lots of people\n\n\n +10 in the sociability's gauge!";
                bars.DealSocialPlus(add_jauge);
                break;

            case 12:        //rallye culturel : jauge sociabilité
                if (save.Get_langue() == 0)
                    text.text = "Vous participez au rallye culturel organisé par l'équipe du WEI\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You take part in the cultural rally organized by the WEI team\n\n\n +10 in the sociability's gauge!";
                bars.DealSocialPlus(add_jauge);
                break;

            case 13:        //soirée des parrains : jauge sociabilité
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez votre parrain lors de la soirée des parrains\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You meet your proposer during the proposer night\n\n\n +10 in your sociability's gauge !";
                bars.DealSocialPlus(add_jauge);
                break;

            case 14:        // sèche les cours après la soirée des parrains : jauge étude diminue
                if (save.Get_langue() == 0)
                    text.text = "Vous vous êtes couché trop tard après la soirée des parrains et séchez le premier cours\n\n\n -10 dans votre jauge étude et assiduité";
                else
                    text.text = "You went to sleep to late after the proposer night and don't go to the first class\n\n\n -10 in your study and diligence's gauge";
                bars.DealEtudeMinus(add_jauge);
                break;

            case 15:        //WEI : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous allez au week end d'intégration et rencontrez pleins d'étudiants\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You go to the integration week end and meet lots of people\n\n\n +10 in your sociability's gauge!";
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
                    text.text = "Vous aidez un ami ayant des difficultés en math\n\n\n +10 dans votre jauge étude et assiduité!";
                else
                    text.text = "You help a friend having difficulties in mathematics\n\n\n +10 in your study and diligence's gauge!";
                bars.DealEtudePlus(add_jauge);
                break;

            case 20:        // passe l'après midi en MDA : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous passez votre après-midi à la MDA et parlez avec beaucoup de personnes\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You spend your afternoon at the MDA and speak with lots of people\n\n\n +10 in your sociability's gauge!";
                bars.DealSocialPlus(add_jauge);
                break;

            case 21:        // pas accepté en cours car + de 15 min de retard : jauge étude diminue
                if (save.Get_langue() == 0)
                    text.text = "Vous arrivez avec 15 minutes de retard et n'êtes pas accepté en cours\n\n\n -10 dans votre étude et assiduité";
                else
                    text.text = "you are 15 mintes late for your course and can't join the class\n\n\n -10 in your study and diligence's gauge!";
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

            case 23://???
                if (save.Get_langue() == 0)
                    text.text = "Vous avez participé à un salon !\n Vous avez gagné un jeton !";
                else
                    text.text = "You have participated at a student exhibition !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 26:        //1_dilemme
                //Travailler ou aller au pod
                button.gameObject.SetActive(false);  

                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous aller au POD organisé à l'Efrei ou passez votre soirée à réviser pour le prochain contrôle ?";
                    btn1_dilemme.GetComponentInChildren<Text>().text = "Aller au POD";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Réviser";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you should you go to the POD organized at Efrei or work all the evening to prepare your next test?";
                    btn1_dilemme.GetComponentInChildren<Text>().text = "Go to the POD";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Revise";
                }

                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);

                break;

            case 27:          //4.1_assos
                // Show Ye'Misticrik, fait partie de l'assos (assos), sinon (social)
                if (save.Get_langue() == 0)
                    Action_Assos("Ye Mistikrik organise un spectacle avec des humoristes", "Ye Mistikrik");
                else
                    Action_Assos("Ye Mistikrik organizes a show gathering humorists", "Ye Mistikrik");
                break;

            case 28: ///???
                if (save.Get_langue() == 0)
                    text.text = "Vous avez participé à la Journée Portes Ouvertes !\n Vous avez gagné un jeton !";
                else
                    text.text = "You have participated at the open day !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 29:
                if (save.Get_langue() == 0)
                    text.text = "C'est la rentrée et vous avez participé à un amphi d'information sur les mobilités !\n Vous avez gagné un jeton !";
                else
                    text.text = "It's the start of the school and you've got an information meeting about mobilities !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 32:          //4.2_assos
                // Mission EFFOR, jauge assos
                if (save.Get_langue() == 0)
                    Action_Assos("Mission EFFOR : vous aidez une entreprise à déménager", "EFFOR");
                else
                    Action_Assos("EFFOR Mission: you help for the move of a firm", "EFFOR");
                break;

            case 33:        //2_dilemme        
                //Participer à L'Iweek ou se concentrer sur ces études
                button.gameObject.SetActive(false);

                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous participer à l'IWeek pour rencontrer des étudiants étrangers ou plutôt vous concentrer sur vos études ?";
                    button.GetComponentInChildren<Text>().text = "Faire l'IWeek";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Se concentrer sur les études";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you take part in the IWeek to meet foreign students or concentrate on your studies?";
                    button.GetComponentInChildren<Text>().text = "Do the IWeek";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Concentrate on studies";
                }
                
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);

                break;

            case 36:        //3_dilemme 
                //Participer au rézal ou réviser pour le contrôle
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous faire le Rézal prévu ce week-end quitte à ne pas beaucoup dormir ou réviser et être en forme pour le contrôle ?";
                    button.GetComponentInChildren<Text>().text = "Faire le Rézal";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Réviser";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you do the Rezal this week-end even if you won't sleep a lot or revise and be ready for the test?";
                    button.GetComponentInChildren<Text>().text = "Do the rezal";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Revise";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
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
                    text.text = "Vous êtes élu délégué de votre classe... félicitations !\n\n\n +10 dans votre jauge étude et assiduité !";
                else
                    text.text = "You have been elected as the new class representative... congratulation !\n\n\n +10 in your study and diligence's gauge!";
                bars.DealEtudePlus(add_jauge);
                break;

            case 39:        //rencontre avec ton fillot : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez votre fillot pour la première fois !\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You meet for the time your protégé !\n\n\n +10 in your sociability's gauge!";
                bars.DealSocialPlus(add_jauge);
                break;

            case 40:        //nouveau choix d'assos : jauge association qui augmente ou diminue
                if (save.Get_langue() == 0)
                    text.text = "Association: choississez de nouvelles assos ou quittez-en à votre guise !";
                else
                    text.text = "Association: Choose new associations or quit some if you want !";
                //appel vers la même fonction que celle du stop choix d'assos, modification des jauges dans la fonction direct

                break;

            case 41:        //4_dilemme     
                //Réunion d'assos ou amphi d'information sur la mobilité
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous aller à un cours de cuisine organisé par Infitah et Efrei Chef ou assister à un amphi d'information sur la mobilité ?";
                    button.GetComponentInChildren<Text>().text = "Aller au cours de cuisine";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Aller à l'amphi";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you should you go to a cuisine course organized by Infitah and Efrei Chef or go to the information meeting on your next mobility?";
                    button.GetComponentInChildren<Text>().text = "Go to the cuisine course";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Go to the meeting";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
                break;

            case 46: //???
                if (save.Get_langue() == 0)
                    text.text = "Découverte de votre campus !\n Vous avez gagné un jeton !";
                else
                    text.text = "Discovery of your campus !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 48: //???
                if (save.Get_langue() == 0)
                    text.text = "C'est la semaine d'intégration !\n Vous avez gagné un jeton !";
                else
                    text.text = "It's the integration week !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;

            case 42:            // Choix destination
                if (save.Get_langue() == 0)
                    text.text = "Vous partez au prochain semestre à l'étranger. Vous devez choisir votre destination !";
                else
                    text.text = "You will leave next semester abroad. You need to choose whether to leave alone or in a group and the location !";
                /// SceneManager.LoadScene(Choix destination);
                break;

            case 43:          //6_assos
                if (save.Get_langue() == 0)
                    Action_Assos("C'est l'heure du Gala annuel de l'Efrei Paris !", "Gala");
                else
                    Action_Assos("It's time for the annual gala ball of Efrei Paris!", "Gala");
                break;

            case 44:        // vous effectué votre stage commercial : jauge étude
                if (save.Get_langue() == 0)
                    text.text = "Vous effectuez votre stage commercial d'un mois\n\n\n +10 dans votre jauge étude et assiduité!";
                else
                    text.text = "You do your commercial internship of one month\n\n\n +10 in your study and diligence's gauge!";
                bars.DealEtudePlus(add_jauge);
                break;

            case 45://case 45 ou case 46 car nb différent selon chemin droite ou gauche de la boucle du plateau
                if (save.Get_langue() == 0)
                    text.text = "Vous rentrez de mobilité !\n Vous avez gagné un jeton !";
                else
                    text.text = "You come back from mobility !\n You've earned a chip !";
                save.Set_jetons(save.Get_jetons() + 1);
                break;


            case 47:        // vous rencontrez vos nouveaux colocs : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez vos nouveaux colocs\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You meet your new housemates\n\n\n +10 in your sociability's gauge!";
                bars.DealSocialPlus(add_jauge);
                break;
                

            case 49:          //7_assos
                // Vous participez à des activités sur le campus (social)
                if (save.Get_langue() == 0)
                    text.text = "Vous participez à des activités organisées sur le campus de votre université\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You take part in activities organized on the campus of your college\n\n\n +10 in your sociability's gauge!";

                bars.DealSocialPlus(add_jauge);
                break;

            case 50:        //5_dilemme
                //Réviser le contrôle ou visiter le pays
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous profiter de votre temps libre pour visiter le pays avec vos amis ou réviser pour vos contrôles ?";
                    button.GetComponentInChildren<Text>().text = "Visiter";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Réviser";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you should you make the most of you free time to visit the country with your friends or revise for your next tests?";
                    button.GetComponentInChildren<Text>().text = "Visit";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Revise";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
                break;

            case 53:        // vous rencontrez des étudiants internationaux : jauge sociale
                if (save.Get_langue() == 0)
                    text.text = "Vous rencontrez des étudiants internationaux sur le campus\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You meet international students on the campus\n\n\n +10 in your sociability's gauge!";

                bars.DealSocialPlus(add_jauge);
                break;

            case 55:        //6_dilemme
                //aider son fillot ou travailler ses propres cours
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nVotre fillot à besoin de vous, devriez vous vous concentrer sur vos propres difficultés ou l'aider à réviser ?";
                    button.GetComponentInChildren<Text>().text = "Travailler pour vous";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Aider votre fillot";
                }
                else
                {
                    text.text = "You face a dilemma! \nYour protégé needs your help, should you concentrate yourself on your own difficulties or help him to revise?";
                    button.GetComponentInChildren<Text>().text = "Work for yourself";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Help your protégé";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
                break;

            case 57:          //8.1_assos
                //On vous propose de faire partie d'une liste BDE (assos) si 3 assos le joueur doit en supprimer 1
                if (save.Get_langue() == 0)
                    text.text = "Vous faite partie d'une liste BDE\n\n\n +10 dans votre jauge association !";
                else
                    text.text = "You take part in a list for the next student's association of Efrei Paris\n\n\n +10 in your association's gauge!";

                save.Add_assos("BDE");
                bars.DealAssosPlus(add_jauge);

                break;

            case 58:        //7_dilemme
                //rentrer pour faire le rapport d'étonnement ou rester pour profiter et bacler son rapport
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nLa fin de votre mobilité approche, devriez vous profiter jusqu'au bout et bacler votre rapport d'étonnement ou rentrer pour faire le rapport ?";
                    button.GetComponentInChildren<Text>().text = "Rester à l'étranger";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Rentrer en France";
                }
                else
                {
                    text.text = "You face a dilemma! \nThe end of your mobility is close, should you go back to France to work on the report ou have to do or stay longer and botch this report?";
                    button.GetComponentInChildren<Text>().text = "Stay abroad";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Go back to France";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
                break;

            case 59:        // Vous rêvez beaucoup de votre mobilité et vous impliquez moins dans votre travail : vos notes baisses, jauge étude diminue
                if (save.Get_langue() == 0)
                    text.text = "Vous rêvez beaucoup de votre mobilité et vous impliquez moins dans votre travail : vos notes baisses\n\n\n -10 dans votre jauge étude et assiduité!";
                else
                    text.text = "You praise to second year's students the destination you choose for your mobility\n\n\n -10 in your study and diligence's gauge!";

                bars.DealSocialPlus(add_jauge);
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
                    text.text = "Vous vantez auprès des L2 la destination que vous avez choisi pour votre mobilité\n\n\n +10 dans votre jauge sociabilité !";
                else
                    text.text = "You praise to second year's students the destination you choose for your mobility\n\n\n +10 in your sociability's gauge!";

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

            case 69:        //8_dilemme
                //travailler sur le PA8 ou aller au POD
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous aller au POD pour décompresser ou avancer sur votre PA8 ?";
                    button.GetComponentInChildren<Text>().text = "Aller au POD";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Avancer sur le PA8";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you should you go to the POD to relax or work on your PA8?";
                    button.GetComponentInChildren<Text>().text = "Go to the POD";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Work on your PA8";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
                break;

            case 73:          //10_assos

                if (save.Get_langue() == 0)
                    Action_Assos("Le groupe Escape organise un Escape Game dans le métro de Paris", "Groupe Escape");
                else
                    Action_Assos("The Escape Group organizes an Escape Game in the Metro of Paris", "Groupe Escape");
                break;

            case 75:        //9_dilemme
                //mettre à jour son CV pour le Campus Day ou vous passez du temps entre amis à la MDA
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous passez du temps avec vos ami à la MDA ou mettre à jour votre cv pour préparer le Campus Day ?";
                    button.GetComponentInChildren<Text>().text = "Aller à la MDA";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Mettre à jour le cv";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you should you spend time with your friends at the MDA or update your resume to prepare the Campus Day?";
                    button.GetComponentInChildren<Text>().text = "Go to the MDA";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Update your resume";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
                break;

            case 78:          //11_assos

                if (save.Get_langue() == 0)
                    Action_Assos("Efrei Microsoft organise une formation pour en savoir plus sur certains logiciels", "Microsoft");
                else
                    Action_Assos("Efrei Microsoft organizes a course training to learn more about some softwares", "Microsoft");
                break;

            case 82:        //10_dilemme
                //Vous prenez du temps pour rechercher un stage de fin d'étude ou vous allez à une soirée Efrei poker
                button.gameObject.SetActive(false);
                if (save.Get_langue() == 0)
                {
                    text.text = "Vous êtes face à un dilemme !\nDevriez vous aller vous amuser à une soirée Efrei Poker ou prendre du temps pour chercher un stage de fin d'étude ?";
                    button.GetComponentInChildren<Text>().text = "Aller à la soirée";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Chercher un stage";
                }
                else
                {
                    text.text = "You face a dilemma! \nShould you should you relax at an Efrei Poker's party or take time to look for your final internship?";
                    button.GetComponentInChildren<Text>().text = "Go to the party";
                    btn2_dilemme.GetComponentInChildren<Text>().text = "Look for an internship";
                }
                btn1_dilemme.gameObject.SetActive(true);
                btn2_dilemme.gameObject.SetActive(true);
                break;

            case 84:          //PV
                if (save.Get_langue() == 0)
                    text.text = "Projet Voltaire !\nEt oui, il faut le repasser... Bonne chance !";
                else
                    text.text = "Projet Voltaire !\nYes, you will need to do it again... Break a leg !";
                /// SceneManager.LoadScene(Quizz du Projet Voltaire);
                break;

            case 85:          //12_assos

                if (save.Get_langue() == 0)
                    Action_Assos("EPS organise une formation pour apprendre à se servir d'un reflexe", "EPS");
                else
                    Action_Assos("EPS organizes a training course to learn how to use a reflex camera", "EPS");
                break;

            case 89:          //13_assos

                if (save.Get_langue() == 0)
                    Action_Assos("La Sepefrei organise un petit déjeuner spécial recrutement", "Sepefrei");
                else
                    Action_Assos("Sepefrei organizes a breakfast in a hiring purpose", "Sepefrei");
                break;


            case 91:          //TOEIC
                if (save.Get_langue() == 0)
                    text.text = "C'est le TOEIC ! Epreuve d'anglais indispensable pour les futurs ingénieurs";
                else
                    text.text = "TOEIC time ! English test essential to futur engineers";
                /// SceneManager.LoadScene(Quizz du TOEIC);
                break;

            case 92:          //14_assos

                if (save.Get_langue() == 0)
                    Action_Assos("L'AI Efrei organise un afterwork entre étudiants actuels et anciens de l'Efrei Paris", "AI efrei");
                else
                    Action_Assos("AI Efrei organizes an afterwork with current and former students of Efrei Paris", "AI efrei");
                break;

            case 97:          //15_assos

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

        if (save.Found_assos(assos_Name)) //fait partie de l'assos
        {
            text.text = action + "\n\n\n+10 dans votre jauge associations !";
            bars.DealAssosPlus(add_jauge);
        }
            
        else
        {
            text.text = action + "\n\n\n+10 dans votre jauge sociabilité !";
            bars.DealSocialPlus(add_jauge);
        }
            

    }

    public void Action_button()
    {
        save.Save_Parameters();
        int i = save.Get_counter();
        CaseDisplay.SetActive(false);

        if (i == 4 || i == 24 || i == 90 || i == 83) // lancer scène quizz
            //SceneManager.LoadScene("Persistent_quizz");
            SceneManager.LoadScene("Persistent_quizz",LoadSceneMode.Additive);
        else if (i == 16) // lancer scène assos
            //SceneManager.LoadScene("Menu Assos");
            SceneManager.LoadScene("Menu Assos", LoadSceneMode.Additive);
        else if(i == 62) // lancer les majeurs
            //SceneManager.LoadScene("Choix des majeurs");
            SceneManager.LoadScene("Choix des majeurs", LoadSceneMode.Additive);
        else if (i == 42) // lancer la scène de choix des destination
            SceneManager.LoadScene("Menu Destinations", LoadSceneMode.Additive);
        //SceneManager.LoadScene("Choix destination");
        else
            StartCoroutine(save.Load_scenes());
        //StartCoroutine(save.Lancer_scene_dés());
    }

    public void OnLeftDilemmaClick()
    {
        save.Save_Parameters();
        int i = save.Get_counter();
        btn1_dilemme.gameObject.SetActive(false);
        btn2_dilemme.gameObject.SetActive(false);
        button.gameObject.SetActive(true);

        int randPlus = Random.Range(1, 3);
        int randMinus = Random.Range(1, 3);

        CaseDisplay.SetActive(false);
        
        if (i == 26 || i == 50 || i == 55 || i == 58 || i == 69 || i == 75)  //-jauge étude, +jauge sociale
        {
            bars.DealEtudeMinus(add_jauge*randMinus/2);
            bars.DealSocialPlus(add_jauge*randPlus/2);
           
        }
        else if (i == 33 || i == 36 || i == 41 || i == 82)      //-jauge étude, + jauge assos
        {
            bars.DealEtudeMinus(add_jauge*randMinus/2);
            bars.DealAssosPlus(add_jauge*randPlus/2);
        }
        //StartCoroutine(save.Lancer_scene_dés());
        StartCoroutine(save.Load_scenes());
    }

    public void OnRightDilemmaClick()
    {
        save.Save_Parameters();
        int i = save.Get_counter();
        btn1_dilemme.gameObject.SetActive(false);
        btn2_dilemme.gameObject.SetActive(false);
        button.gameObject.SetActive(true);

        int randPlus = Random.Range(1, 3);
        int randMinus = Random.Range(1, 3);

        CaseDisplay.SetActive(false);

        if (i == 26 || i == 50 || i == 55 || i == 58 || i == 69 || i == 75)  //+jauge étude, - jauge sociale
        {
            bars.DealEtudePlus(add_jauge*randPlus/2);
            bars.DealSocialMinus(add_jauge*randMinus/2);
        }
        else if (i == 33 || i == 36 || i == 41 || i == 82)      //+jauge étude, - jauge assos
        {
            bars.DealEtudePlus(add_jauge*randPlus/2);
            bars.DealAssosMinus(add_jauge*randMinus/2);
        }
        //StartCoroutine(save.Lancer_scene_dés());
        StartCoroutine(save.Load_scenes());
    }

}
