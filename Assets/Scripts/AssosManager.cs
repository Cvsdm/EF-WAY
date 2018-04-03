﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AssosManager : MonoBehaviour
{
    //Menu
    public Text text_1, text_1_2, text_2, text_2_2, text_3, text_3_2, text_4, text_4_2, text_5, text_5_2, text_6, text_6_2, text_7, text_7_2, text_8, text_8_2, text_9, text_9_2;
    public Sprite sprite1, sprite2, sprite3, sprite4, sprite5, sprite6, sprite7, sprite8, sprite9;
    public Image image1, image2, image3, image4, image5, image6, image7, image8, image9;

    //Pro
    public Text text_10, text_10_2, text_11, text_11_2, text_12, text_12_2, text_13, text_13_2, text_14, text_14_2;
    public Sprite sprite10, sprite11, sprite12, sprite13, sprite14;
    public Image image10, image11, image12, image13, image14;

    //Media
    public Text text_15, text_15_2, text_16, text_16_2, text_17, text_17_2;
    public Sprite sprite15, sprite16, sprite17;
    public Image image15, image16, image17;

    //Inter
    public Text text_18, text_18_2, text_19, text_19_2, text_20, text_20_2, text_21, text_21_2;
    public Sprite sprite18, sprite19, sprite20, sprite21;
    public Image image18, image19, image20, image21;

    //Culture
    public Text text_22, text_22_2, text_23, text_23_2, text_24, text_24_2, text_25, text_25_2, text_26, text_26_2, text_27, text_27_2, text_28, text_28_2, text_29, text_29_2, text_30, text_30_2, text_31, text_31_2, text_32, text_32_2;
    public Sprite sprite22, sprite23, sprite24, sprite25, sprite26, sprite27, sprite28, sprite29, sprite30, sprite31, sprite32;
    public Image image22, image23, image24, image25, image26, image27, image28, image29, image30, image31, image32;

    //Sport
    public Text text_33, text_33_2, text_34, text_34_2, text_35, text_35_2, text_36, text_36_2, text_37, text_37_2, text_38, text_38_2, text_39, text_39_2, text_40, text_40_2, text_41, text_41_2, text_42, text_42_2, text_43, text_43_2;
    public Sprite sprite33, sprite34, sprite35, sprite36, sprite37, sprite38, sprite39, sprite40, sprite41, sprite42, sprite43;
    public Image image33, image34, image35, image36, image37, image38, image39, image40, image41, image42, image43;

    //Events
    public Text text_45, text_45_2, text_46, text_46_2;
    public Sprite sprite45, sprite46;
    public Image image45, image46;

    //Technique
    public Text text_47, text_47_2, text_48, text_48_2, text_49, text_49_2, text_50, text_50_2, text_51, text_51_2, text_52, text_52_2, text_53, text_53_2, text_54, text_54_2;
    public Sprite sprite47, sprite48, sprite49, sprite50, sprite51, sprite52, sprite53, sprite54;
    public Image image47, image48, image49, image50, image51, image52, image53, image54;

    //Entraide
    public Text text_55, text_55_2, text_56, text_56_2, text_57, text_57_2, text_58, text_58_2, text_59, text_59_2, text_60, text_60_2;
    public Sprite sprite55, sprite56, sprite57, sprite58, sprite59, sprite60;
    public Image image55, image56, image57, image58, image59, image60;

    int choixAssos;

    int langue = 1;



    public void Start()
    {
        /*   association = new int[4];
           association[0] = 0;
           association[1] = 0;
           association[2] = 0;*/


        IniVariables();

        if (langue == 1)
        {
            IniFrench();
        }
        else if (langue == 2)
        {
            IniEnglish();
        }
    }

    void IniVariables()
    {
        /*   text_1_2 = GameObject.Find("Text1_D").GetComponent<Text>();
           text_2_2 = GameObject.Find("Text2_D").GetComponent<Text>();
           text_3_2 = GameObject.Find("Text3_D").GetComponent<Text>();
           text_4_2 = GameObject.Find("Text4_D").GetComponent<Text>();
           text_5_2 = GameObject.Find("Text5_D").GetComponent<Text>();
           text_6_2 = GameObject.Find("Text6_D").GetComponent<Text>();
           text_7_2 = GameObject.Find("Text7_D").GetComponent<Text>();
           text_8_2 = GameObject.Find("Text8_D").GetComponent<Text>();
           text_9_2 = GameObject.Find("Text9_D").GetComponent<Text>();
           text_10_2 = GameObject.Find("Text10_D").GetComponent<Text>();
           text_11_2 = GameObject.Find("Text11_D").GetComponent<Text>();
           text_12_2 = GameObject.Find("Text12_D").GetComponent<Text>();
           text_13_2 = GameObject.Find("Text13_D").GetComponent<Text>();
           text_14_2 = GameObject.Find("Text14_D").GetComponent<Text>();
           text_15_2 = GameObject.Find("Text15_D").GetComponent<Text>();
           text_16_2 = GameObject.Find("Text16_D").GetComponent<Text>();
           text_17_2 = GameObject.Find("Text17_D").GetComponent<Text>();
           text_18_2 = GameObject.Find("Text18_D").GetComponent<Text>();
           text_19_2 = GameObject.Find("Text19_D").GetComponent<Text>();
           text_20_2 = GameObject.Find("Text20_D").GetComponent<Text>();
           text_21_2 = GameObject.Find("Text21_D").GetComponent<Text>();
           text_22_2 = GameObject.Find("Text22_D").GetComponent<Text>();
           text_23_2 = GameObject.Find("Text23_D").GetComponent<Text>();
           text_24_2 = GameObject.Find("Text24_D").GetComponent<Text>();
           text_25_2 = GameObject.Find("Text25_D").GetComponent<Text>();
           text_26_2 = GameObject.Find("Text26_D").GetComponent<Text>();
           text_27_2 = GameObject.Find("Text27_D").GetComponent<Text>();
           text_28_2 = GameObject.Find("Text28_D").GetComponent<Text>();
           text_29_2 = GameObject.Find("Text29_D").GetComponent<Text>();
           text_30_2 = GameObject.Find("Text30_D").GetComponent<Text>();
           text_31_2 = GameObject.Find("Text31_D").GetComponent<Text>();
           text_32_2 = GameObject.Find("Text32_D").GetComponent<Text>();


           text_1 = GameObject.Find("Text1").GetComponent<Text>();
           text_2 = GameObject.Find("Text2").GetComponent<Text>();
           text_3 = GameObject.Find("Text3").GetComponent<Text>();
           text_4 = GameObject.Find("Text4").GetComponent<Text>();
           text_5 = GameObject.Find("Text5").GetComponent<Text>();
           text_6 = GameObject.Find("Text6").GetComponent<Text>();
           text_7 = GameObject.Find("Text7").GetComponent<Text>();
           text_8 = GameObject.Find("Text8").GetComponent<Text>();
           text_9 = GameObject.Find("Text9").GetComponent<Text>();
           text_10 = GameObject.Find("Text10").GetComponent<Text>();
           text_11 = GameObject.Find("Text11").GetComponent<Text>();
           text_12 = GameObject.Find("Text12").GetComponent<Text>();
           text_13 = GameObject.Find("Text13").GetComponent<Text>();
           text_14 = GameObject.Find("Text14").GetComponent<Text>();
           text_15 = GameObject.Find("Text15").GetComponent<Text>();
           text_16 = GameObject.Find("Text16").GetComponent<Text>();
           text_17 = GameObject.Find("Text17").GetComponent<Text>();
           text_18 = GameObject.Find("Text18").GetComponent<Text>();
           text_19 = GameObject.Find("Text19").GetComponent<Text>();
           text_20 = GameObject.Find("Text20").GetComponent<Text>();
           text_21 = GameObject.Find("Text21").GetComponent<Text>();
           text_22 = GameObject.Find("Text22").GetComponent<Text>();
           text_23 = GameObject.Find("Text23").GetComponent<Text>();
           text_24 = GameObject.Find("Text24").GetComponent<Text>();
           text_25 = GameObject.Find("Text25").GetComponent<Text>();
           text_26 = GameObject.Find("Text26").GetComponent<Text>();
           text_27 = GameObject.Find("Text27").GetComponent<Text>();
           text_28 = GameObject.Find("Text28").GetComponent<Text>();
           text_29 = GameObject.Find("Text29").GetComponent<Text>();
           text_30 = GameObject.Find("Text30").GetComponent<Text>();
           text_31 = GameObject.Find("Text31").GetComponent<Text>();
           text_32 = GameObject.Find("Text32").GetComponent<Text>();

           image1 = GameObject.Find("Image1_D").GetComponent<Image>();
           image2 = GameObject.Find("Image2_D").GetComponent<Image>();
           image3 = GameObject.Find("Image3_D").GetComponent<Image>();
           image4 = GameObject.Find("Image4_D").GetComponent<Image>();
           image5 = GameObject.Find("Image5_D").GetComponent<Image>();
           image6 = GameObject.Find("Image6_D").GetComponent<Image>();
           image7 = GameObject.Find("Image7_D").GetComponent<Image>();
           image8 = GameObject.Find("Image8_D").GetComponent<Image>();
           image9 = GameObject.Find("Image9_D").GetComponent<Image>();
           image10 = GameObject.Find("Image10_D").GetComponent<Image>();
           image11 = GameObject.Find("Image11_D").GetComponent<Image>();
           image12 = GameObject.Find("Image12_D").GetComponent<Image>();
           image13 = GameObject.Find("Image13_D").GetComponent<Image>();
           image14 = GameObject.Find("Image14_D").GetComponent<Image>();
           image15 = GameObject.Find("Image15_D").GetComponent<Image>();
           image16 = GameObject.Find("Image16_D").GetComponent<Image>();
           image17 = GameObject.Find("Image17_D").GetComponent<Image>();
           image18 = GameObject.Find("Image18_D").GetComponent<Image>();
           image19 = GameObject.Find("Image19_D").GetComponent<Image>();
           image20 = GameObject.Find("Image20_D").GetComponent<Image>();
           image21 = GameObject.Find("Image21_D").GetComponent<Image>();
           image22 = GameObject.Find("Image22_D").GetComponent<Image>();
           image23 = GameObject.Find("Image23_D").GetComponent<Image>();
           image24 = GameObject.Find("Image24_D").GetComponent<Image>();
           image25 = GameObject.Find("Image25_D").GetComponent<Image>();
           image26 = GameObject.Find("Image26_D").GetComponent<Image>();
           image27 = GameObject.Find("Image27_D").GetComponent<Image>();
           image28 = GameObject.Find("Image28_D").GetComponent<Image>();
           image29 = GameObject.Find("Image29_D").GetComponent<Image>();
           image30 = GameObject.Find("Image30_D").GetComponent<Image>();
           image31 = GameObject.Find("Image31_D").GetComponent<Image>();
           image32 = GameObject.Find("Image32_D").GetComponent<Image>();

         */
        image1.sprite = sprite1;
        image2.sprite = sprite2;
        image3.sprite = sprite3;
        image4.sprite = sprite4;
        image5.sprite = sprite5;
        image6.sprite = sprite6;
        image7.sprite = sprite7;
        image8.sprite = sprite8;
        image9.sprite = sprite9;
        image10.sprite = sprite10;
        image11.sprite = sprite11;
        image12.sprite = sprite12;
        image13.sprite = sprite13;
        image14.sprite = sprite14;
        image15.sprite = sprite15;
        image16.sprite = sprite16;
        image17.sprite = sprite17;
        image18.sprite = sprite18;
        image19.sprite = sprite19;
        image20.sprite = sprite20;
        image21.sprite = sprite21;
        image22.sprite = sprite22;
        image23.sprite = sprite23;
        image24.sprite = sprite24;
        image25.sprite = sprite25;
        image26.sprite = sprite26;
        image27.sprite = sprite27;
        image28.sprite = sprite28;
        image29.sprite = sprite29;
        image30.sprite = sprite30;
        image31.sprite = sprite31;
        image32.sprite = sprite32;
        image33.sprite = sprite33;
        image34.sprite = sprite34;
        image35.sprite = sprite35;
        image36.sprite = sprite36;
        image37.sprite = sprite37;
        image38.sprite = sprite38;
        image39.sprite = sprite39;
        image40.sprite = sprite40;
        image41.sprite = sprite41;
        image42.sprite = sprite42;
        image43.sprite = sprite43;
        image45.sprite = sprite45;
        image46.sprite = sprite46;
        image47.sprite = sprite47;
        image48.sprite = sprite48;
        image49.sprite = sprite49;
        image50.sprite = sprite50;
        image51.sprite = sprite51;
        image52.sprite = sprite52;
        image53.sprite = sprite53;
        image54.sprite = sprite54;
        image55.sprite = sprite55;
        image56.sprite = sprite56;
        image57.sprite = sprite57;
        image58.sprite = sprite58;
        image59.sprite = sprite59;
        image60.sprite = sprite60;
    }

    void IniFrench()
    {
        // Menu
        text_1.text = "BDE";
        text_1_2.text = "Le Bureau des Elèves est en charge de l'animation du campus";
        text_2.text = "Professionnel";
        text_2_2.text = "Junior Entreprise\nFormation aux entreprises\nOrganisation d'événements\nEntreprenariat";
        text_3.text = "Média";
        text_3_2.text = "Radio\nPhoto\nVidéo\nPresse";
        text_4.text = "International";
        text_4_2.text = "Journée découverte\nRencontres avec les étudiants étrangers";
        text_5.text = "Culture et Loisirs";
        text_5_2.text = "Musique\nDanse\nThéâtre\nJeux de rôle et de cartes";
        text_6.text = "Sports";
        text_6_2.text = "Football\nParachutisme\nVoile\nBadminton\nRugby\nVolley-ball";
        text_7.text = "Evénementiel";
        text_7_2.text = "Weekend d'intégration\nGala\nExpositions\nSoirées";
        text_8.text = "Technique";
        text_8_2.text = "Robotique\nJeux vidéos\n3D\nLinux";
        text_9.text = "Entraide";
        text_9_2.text = "Humanitaire\nFormation à des particuliers\nSoutien scolaire";

        // Assos Pro
        text_10.text = "SEPEFREI";
        text_10_2.text = "Junior Entreprise";
        text_11.text = "EFFOR";
        text_11_2.text = "EFrei FORmation\nFormations et réalisation de prestations techniques dans le domaine des nouvelles technologies";
        text_12.text = "EFFI";
        text_12_2.text = "Efrei Finance\nInitier les élèves au secteur de la finance et ses outils";
        text_13.text = "PISTE";
        text_13_2.text = "Portail d'Information pour les Stages en Entreprises\nCV\nCampus day\nConférences";
        text_14.text = "AI EFREI";
        text_14_2.text = "Association des ingénieurs du groupe EFREI pour actuels et anciens étudiants";

        // Assos media
        text_15.text = "EPS";
        text_15_2.text = "EFREI Picture Studio\nAssociation de photos et vidéos\nCouvre tous les événements du campus";
        text_16.text = "Rename";
        text_16_2.text = "Journal des étudiants\nLien entre élèves, administration et associations";
        text_17.text = "Ready'O";
        text_17_2.text = "Radio de l'école\nInterview, événements, activités, musique";

        // Assos inter
        text_18.text = "EFREI International";
        text_18_2.text = "Acceuille les élèves étrangers qui intègre l'Efrei Paris\nRusses, chinois, allemands, australiens, indiens...";
        text_19.text = "Asian EFREI";
        text_19_2.text = "Consacrée à la découverte des cultures asiatiques";
        text_20.text = "I Week";
        text_20_2.text = "Acceuille les élèves d'écoles et universités partenaires";
        text_21.text = "Infitah";
        text_21_2.text = "Consacrée à la culture maghrébine au sein du campus";

        // Assos Culture et loisirs
        text_22.text = "Yé Mistikrik";
        text_22_2.text = "Spectacles, sketches, représentations étudiantes et humoristes";
        text_23.text = "Live EFREI";
        text_23_2.text = "Consacrée aux instruments de musiques\nReprésentations, cours,...";
        text_24.text = "Club Rézo";
        text_24_2.text = "Organise le Rézal : 24heures non stop de jeux, tournois, musique sur le campus";
        text_25.text = "EFREI Poker";
        text_25_2.text = "Propose de pratiquer le poker, apprendre ou se perfectionner";
        text_26.text = "Taverne";
        text_26_2.text = "Jeux de cartes, rôles, tournois ...";
        text_27.text = "Millésisme";
        text_27_2.text = "Initiation à la dégustation de vins";
        text_28.text = "Groupe Escape";
        text_28_2.text = "Scénarise et donne vie à des Escape Games sur le campus";
        text_29.text = "Pen Soul";
        text_29_2.text = "Club de dessin\nIllustration du journal de l'école, sorties culturelles ...";
        text_30.text = "Le Continental";
        text_30_2.text = "Gestion de la K-fet, rénovation, entretien ...\nEspace de détente, soirée, projection...";
        text_31.text = "EFREI Chefs";
        text_31_2.text = "Apprendre les rudiments essentiels de la cuisine orienté étudiante";
        text_32.text = "HIFI LIX";
        text_32_2.text = "Association de DJ\nMixage, éclairage pendant les événements\nProduction de musique";

        // Sports
        text_33.text = "Bureau des Sports (BDS)";
        text_33_2.text = "Football, rugby, basketball, badminton, tennis, natation";
        text_34.text = "Efreestyle";
        text_34_2.text = "Hip hop, capoeira, salsa, break dance";
        text_35.text = "Efight";
        text_35_2.text = "Dédié aux sports de combat\nPratique des arts martiaux\nCours d'autodéfense";
        text_36.text = "EF Racing";
        text_36_2.text = "Association de karting et automobile";
        text_37.text = "EF'Ride";
        text_37_2.text = "Glisse urbaine : cyclisme, planches, roller...\nGlisse aquatique : wakeboard, windsurf, kitesurf, speed sail";
        text_38.text = "Cap Efrei";
        text_38_2.text = "Initiation à la voile\nReprésente l'école à la course croisière EDHEC";
        text_39.text = "EFREI Sport Climbing";
        text_39_2.text = "Association d'escalade";
        text_40.text = "EFREI Para";
        text_40_2.text = "Fais découvrir la chute libre avec l'association de parachutisme";
        text_41.text = "EFRAY";
        text_41_2.text = "Pour les passionnés de Laser Game\nAffrontements organisés après les cours dans le Laser Game Evolution de Paris 14";
        text_42.text = "Hock'Efrei";
        text_42_2.text = "Compétitions internationales de hockey sur glace";
        text_43.text = "4eSport EFREI";
        text_43_2.text = "Pour les passionnés d'e-sport qui souhaitent intégrer une équipe e-sportive\nTournois et LAN";

        //Events
        text_45.text = "Week-end d'intégration";
        text_45_2.text = "Associaiton qui accueille les nouveaux étudiants\nEvénements organisés pendant lors du mois d'arrivée (petit déjeuner, rallye culturel, barbecue, soirées...)";
        text_46.text = "Gala EFREI";
        text_46_2.text = "Etudiants, diplômés, membres de l'administration..\nTous invités dans une grande salle parisienne pour une soirée d'exception";

        //Technique
        text_47.text = "ICE EFREI";
        text_47_2.text = "Possibilité d'approfondir les connaissances techniques et mener des projets Recherche & Développement sur les technologies de l'information et de la communicaiton";
        text_48.text = "EFREI Microsoft";
        text_48_2.text = "Prend la forme d'un Student Club\nDédié aux technologies Microsoft\nConférences, formations...";
        text_49.text = "EFREI 3D";
        text_49_2.text = "Intéressés par la modélisation et l'animation 3D\nFormations, interventions de spécialistes...\nOutils nécéssaires pour la réalisation";
        text_50.text = "Crobot'ic";
        text_50_2.text = "Représente l'école à la Coupe de France de Robotique\nAssociation de robotique";
        text_51.text = "EFREI Linus";
        text_51_2.text = "Dédiée au logiciel libre\nFormations, Install Party...";
        text_52.text = "Aero EFREI";
        text_52_2.text = "Rassemble les élèves passionnés d'aéronotique\n3 pôles : formation, espace, aéronautique\nSimulateurs, ballons sondes...";
        text_53.text = "GET";
        text_53_2.text = "Consacrée aux technologies du web\nGoodle AdWords, Android, Gmail, GWT, SEO, Google Apples...";
        text_54.text = "EFREI Crypto Paris";
        text_54_2.text = "Vulgarise et aide les personnes à s'intéresser à la crypto monnaie";

        //Entraide
        text_55.text = "Formation Aux Particuliers (FAP)";
        text_55_2.text = "Rends accessibles les technologies de l'information au plus grand nombre\nPersonnes âgées, légèrement handicapées, collégiens";
        text_56.text = "EFREI Aides Humanitaires (EAH)";
        text_56_2.text = "Favorise l'égalité de l'accès à l'éducation\nConvois humanitaires (Burkina, Madagascar, Sénégal, Rwanda...)";
        text_57.text = "Symbioz EFREI";
        text_57_2.text = "Actions de terrain contre l'impact environnemental de l'industrie indormatique\nTri sélectif, collectes de piles...";
        text_58.text = "Entraide";
        text_58_2.text = "Promeut l'entraide entre les élèves du groupe\nFormations entre élèves";
        text_59.text = "Human'App";
        text_59_2.text = "Développe des applications à destiation des personnes âgées, ONG humanitaires...\nLigue contre le cancer\nRelation avec l'hôpital Paul Brousse";
        text_60.text = "4L & FAONS";
        text_60_2.text = "Participe au 4L Trophy\nRaid automobile humanitaire destiné aux étudiants";
    }

    void IniEnglish()
    {
        // Menu
        text_1.text = "Student Office";
        text_1_2.text = "The Student Office is in charge of the campus animations";
        text_2.text = "Professionnal";
        text_2_2.text = "Junior Entreprise\nTraining to firms\nEvents organisations\nEntrepreneurship";
        text_3.text = "Media";
        text_3_2.text = "Radio\nPhoto\nVideo\nPress";
        text_4.text = "International";
        text_4_2.text = "Discover days\nMeetings with foreigners";
        text_5.text = "Culture and Hobbys";
        text_5_2.text = "Music\nDance\nTheatre\nRole plays and card games";
        text_6.text = "Sports";
        text_6_2.text = "Football\nSkydiving\nSailing\nBadminton\nRugby\nVolleyball";
        text_7.text = "Events";
        text_7_2.text = "Integration weekend\nGala\nExhibitions\nParties";
        text_8.text = "Technics";
        text_8_2.text = "Robotics\nVideo games\n3D\nLinux";
        text_9.text = "Mutual Aid";
        text_9_2.text = "Humanitarian\nIndividual training\nAccademic support";

        // Assos Pro
        text_10.text = "SEPEFREI";
        text_10_2.text = "Junior Entreprise";
        text_11.text = "EFFOR";
        text_11_2.text = "EFrei FORmation\nTrainings and technic implementation in new technologies";
        text_12.text = "EFFI";
        text_12_2.text = "Efrei Finance\nInitiate students in the field of finance";
        text_13.text = "PISTE";
        text_13_2.text = "Portal of information for firms' internships\nCV\nCampus day\nConferences";
        text_14.text = "AI EFREI";
        text_14_2.text = "Association of actual and former studients in EFREI";

        // Assos media
        text_15.text = "EPS";
        text_15_2.text = "EFREI Picture Studio\nAssociation dedicated to pictures and videos\nCovers every events of the school";
        text_16.text = "Rename";
        text_16_2.text = "Newspaper of the students\nLink between students, administration and associations";
        text_17.text = "Ready'O";
        text_17_2.text = "Radio of the school\nInterviews, events, activities, music";

        // Assos inter
        text_18.text = "EFREI International";
        text_18_2.text = "Welcomes foreigners students that come to study in Efrei Paris\nRussians, Chinese, Germans, Australiens, Indians...";
        text_19.text = "Asian EFREI";
        text_19_2.text = "Dedicated to the discovery of Asian culture";
        text_20.text = "I Week";
        text_20_2.text = "Welcomes foreigners students from partners universities and schools";
        text_21.text = "Infitah";
        text_21_2.text = "Dedicated to the discovery of culture of the Maghreb";

        // Assos Culture et loisirs
        text_22.text = "Yé Mistikrik";
        text_22_2.text = "Shows, stand ups, performances by students and comedians";
        text_23.text = "Live EFREI";
        text_23_2.text = "Dedicated to musical instruments\nPerformances, courses,...";
        text_24.text = "Club Rézo";
        text_24_2.text = "Organizes the 'Rézal' : 24hours non stop of gaming, tournaments, music on campus";
        text_25.text = "EFREI Poker";
        text_25_2.text = "Offers to learn poker, train or perfect the art";
        text_26.text = "Taverne";
        text_26_2.text = "Cards games, role plays, tournaments...";
        text_27.text = "Millésisme";
        text_27_2.text = "Initiation to wine tasting";
        text_28.text = "Groupe Escape";
        text_28_2.text = "Creates Escape Games on campus";
        text_29.text = "Pen Soul";
        text_29_2.text = "Drawing club\nIllustrates the school newspaper, cultural hangouts ...";
        text_30.text = "Le Continental";
        text_30_2.text = "Manages the K-fet, the renovation, the maintenance...\nRoom to relax, party,...";
        text_31.text = "EFREI Chefs";
        text_31_2.text = "Learn the basics to cooking for a student";
        text_32.text = "HIFI LIX";
        text_32_2.text = "Association of DJ\nMixing, spotlights during events\nMusic production";

        // Sports
        text_33.text = "Bureau des Sports (BDS)";
        text_33_2.text = "Football, rugby, basketball, badminton, tennis, swimming";
        text_34.text = "Efreestyle";
        text_34_2.text = "Hip hop, capoeira, salsa, breakdance";
        text_35.text = "Efight";
        text_35_2.text = "Dedicated to combat sports\nPractice martial arts\nClasses of self defense";
        text_36.text = "EF Racing";
        text_36_2.text = "Association of karting and automobile";
        text_37.text = "EF'Ride";
        text_37_2.text = "Cyycling, board sports, roller blading, wakeboard, windsurfing, kitesurf, speed sail";
        text_38.text = "Cap Efrei";
        text_38_2.text = "Initiation to sailing\nRepresents the school for the Cruise Race EDHEC";
        text_39.text = "EFREI Sport Climbing";
        text_39_2.text = "Climbing association";
        text_40.text = "EFREI Para";
        text_40_2.text = "Discover free fall with the skydiving associaiton";
        text_41.text = "EFRAY";
        text_41_2.text = "For lovers of Game Tags\nBattles organized after classes in the Game Tag Evolution Paris 14";
        text_42.text = "Hock'Efrei";
        text_42_2.text = "International hockey on ice competition";
        text_43.text = "4eSport EFREI";
        text_43_2.text = "For lovers of e-sports who wish to join a team\nTournaments and LAN parties";

        //Events
        text_45.text = "Orientation Weekend";
        text_45_2.text = "Association with the goal of welcoming new students\nMany events organized during their first month : breakfast, cultural rally, Sidaction day, barbecue, parties...";
        text_46.text = "Gala EFREI";
        text_46_2.text = "Students, graduates, members of the administration...\nAll invited to a huge Parisian ball room for a night to remember";

        //Technique
        text_47.text = "ICE EFREI";
        text_47_2.text = "Possibility to widden the knowledge and lead project in Research & Developpement on information technologies and communication";
        text_48.text = "EFREI Microsoft";
        text_48_2.text = "Takes the form of a Student Club\nDedicated to Microsoft technologies\nConferences, courses...";
        text_49.text = "EFREI 3D";
        text_49_2.text = "For those interessed in 3D modelisation and animation\nCourses, specialists conferences...\nTools available for production";
        text_50.text = "Crobot'ic";
        text_50_2.text = "Represents the school for the 'Coupe de France de Robotique'\nRobotics association";
        text_51.text = "EFREI Linus";
        text_51_2.text = "Dedicated to free software\nCourses, Install Parties...";
        text_52.text = "Aero EFREI";
        text_52_2.text = "Gathers lovers of aeronautics\n3 poles : courses, space, aeraunotics\nSimulators, sounding ballon...";
        text_53.text = "GET";
        text_53_2.text = "Dedicated to new technologies of the web\nGoodle AdWords, Android, Gmail, GWT, SEO, Google Apps...";
        text_54.text = "EFREI Crypto Paris";
        text_54_2.text = "Popularizes and help people take an interest in crypto currency";

        //Entraide
        text_55.text = "Formation Aux Particuliers (FAP)";
        text_55_2.text = "Makes available information technologies to people\nElderly, slightly handicapped, students";
        text_56.text = "EFREI Aides Humanitaires (EAH)";
        text_56_2.text = "Improves the equality of the education access\nHumanitarian convoys (Burkina, Madagascar, Senegal, Rwanda...)";
        text_57.text = "Symbioz EFREI";
        text_57_2.text = "Field action against the impact of environmental Impact of IT \nRecycling, collection bins of used batteries";
        text_58.text = "Entraide";
        text_58_2.text = "Promotes the mutual aid between students of the group\nCourses between students";
        text_59.text = "Human'App";
        text_59_2.text = "Developps apps for elderly, hospitals and NGO\nCancer Ligue\nLinks with the Paul Brousse hospital";
        text_60.text = "4L & FAONS";
        text_60_2.text = "Takes part in the 4L Trophy\nHumanitarian automobile raid dedicated to students";
    }



    public void ChangeLanguageToEn()
    {
        langue = 2;
        IniEnglish();
    }

    public void ChangeLanguageToFr()
    {
        langue = 1;
        IniFrench();
    }


    //   public int[] association;

    public void Choice(int temp)
    {
        if (temp == 1)   // BDE
        {
            //association[i] = 1;
            choixAssos = 1;
            Debug.Log("BDE");
            SceneManager.LoadScene(1);
        }

        if (temp == 2)   // Sepefrei
        {
            //association[i] = 2;
            choixAssos = 2;
            Debug.Log("Sepefrei");
            SceneManager.LoadScene(1);
        }

        if (temp == 3)   // Effor
        {
            //association[i] = 3;
            choixAssos = 3;
            Debug.Log("Effor");
            SceneManager.LoadScene(1);
        }

        if (temp == 4)   // Effi
        {
            //association[i] = 4;
            choixAssos = 4;
            Debug.Log("Effi");
            SceneManager.LoadScene(1);
        }

        if (temp == 5)   // Piste
        {
            //association[i] = 5;
            choixAssos = 5;
            Debug.Log("Piste");
            SceneManager.LoadScene(1);
        }

        if (temp == 6)   // AI EFREI
        {
            //association[i] = 6;
            choixAssos = 6;
            Debug.Log("AI efrei");
            SceneManager.LoadScene(1);
        }

        if (temp == 7)   // EPS
        {
            //association[i] = 7;
            choixAssos = 7;
            Debug.Log("EPS");
            SceneManager.LoadScene(1);
        }

        if (temp == 8)   // Rename
        {
            //association[i] = 8;
            choixAssos = 8;
            Debug.Log("Rename");
            SceneManager.LoadScene(1);
        }

        if (temp == 9)   // Ready o
        {
            //association[i] = 9;
            choixAssos = 9;
            Debug.Log("Ready o");
            SceneManager.LoadScene(1);
        }

        if (temp == 10)   // Efrei int
        {
            //association[i] = 10;
            choixAssos = 10;
            Debug.Log("Efrei int");
            SceneManager.LoadScene(1);
        }

        if (temp == 11)   // Asian
        {
            //association[i] = 11;
            choixAssos = 11;
            Debug.Log("Asian");
            SceneManager.LoadScene(1);
        }

        if (temp == 12)   // I week
        {
            //association[i] = 12;
            choixAssos = 12;
            Debug.Log("I week");
            SceneManager.LoadScene(1);
        }

        if (temp == 13)   // Infitah
        {
            //association[i] = 13;
            choixAssos = 13;
            Debug.Log("Infitah");
            SceneManager.LoadScene(1);
        }


        if (temp == 14)   // Yé mistikrirk
        {
            //association[i] = 14;
            choixAssos = 14;
            Debug.Log("Yé M");
            SceneManager.LoadScene(1);
        }

        if (temp == 15)   // Live Efrei
        {
            //association[i] = 15;
            choixAssos = 15;
            Debug.Log("Live Efrei");
            SceneManager.LoadScene(1);
        }

        if (temp == 16)   // Club Rézo
        {
            //association[i] = 16;
            choixAssos = 16;
            Debug.Log("Club Rézo");
            SceneManager.LoadScene(1);
        }

        if (temp == 17)   // Efrei Poker
        {
            //association[i] = 17;
            choixAssos = 17;
            Debug.Log("Efrei Poker");
            SceneManager.LoadScene(1);
        }

        if (temp == 18)   // Taverne
        {
            //association[i] = 13;
            choixAssos = 13;
            Debug.Log("Infitah");
            SceneManager.LoadScene(1);
        }

        if (temp == 19)   // Millésisme
        {
            //association[i] = 19;
            choixAssos = 19;
            Debug.Log("Millésisme");
            SceneManager.LoadScene(1);
        }

        if (temp == 20)   // Groupe Escape
        {
            //association[i] = 20;
            choixAssos = 20;
            Debug.Log("Groupe Escape");
            SceneManager.LoadScene(1);
        }

        if (temp == 21)   // Pen soul
        {
            //association[i] = 21;
            choixAssos = 21;
            Debug.Log("Pen Soul");
            SceneManager.LoadScene(1);
        }

        if (temp == 22)   // Le Continental
        {
            //association[i] = 22;
            choixAssos = 22;
            Debug.Log("Continental");
            SceneManager.LoadScene(1);
        }

        if (temp == 23)   // EfreiChef
        {
            //association[i] = 23;
            choixAssos = 23;
            Debug.Log("Efrei Chefs");
            SceneManager.LoadScene(1);
        }

        if (temp == 24)   // Hifi Lix
        {
            //association[i] = 24;
            choixAssos = 24;
            Debug.Log("Hifi Lix");
            SceneManager.LoadScene(1);
        }

        if (temp == 25)   // bds
        {
            //association[i] = 25;
            choixAssos = 25;
            Debug.Log("bds");
            SceneManager.LoadScene(1);
        }

        if (temp == 26)   // efreestyle
        {
            //association[i] = 26;
            choixAssos = 26;
            Debug.Log("efreestyle");
            SceneManager.LoadScene(1);
        }

        if (temp == 27)   // efight
        {
            //association[i] = 27;
            choixAssos = 27;
            Debug.Log("efight");
            SceneManager.LoadScene(1);
        }

        if (temp == 28)   // ef racing
        {
            //association[i] = 28;
            choixAssos = 28;
            Debug.Log("ef racing");
            SceneManager.LoadScene(1);
        }

        if (temp == 29)   // ef ride
        {
            //association[i] = 29;
            choixAssos = 29;
            Debug.Log("ef ride");
            SceneManager.LoadScene(1);
        }

        if (temp == 30)   // cap efrei
        {
            //association[i] = 30;
            choixAssos = 30;
            Debug.Log("cap efrei");
            SceneManager.LoadScene(1);
        }

        if (temp == 31)   // efrei climbing
        {
            //association[i] = 31;
            choixAssos = 31;
            Debug.Log("climbing");
            SceneManager.LoadScene(1);
        }

        if (temp == 32)   // para
        {
            //association[i] = 32;
            choixAssos = 32;
            Debug.Log("para");
            SceneManager.LoadScene(1);
        }

        if (temp == 33 )   // efray
        {
            //association[i] = 33;
            choixAssos = 33;
            Debug.Log("efray");
            SceneManager.LoadScene(1);
        }

        if (temp == 34)   // hock
        {
            //association[i] = 34;
            choixAssos = 34;
            Debug.Log("hock");
            SceneManager.LoadScene(1);
        }

        if (temp == 35)   // 4e sport
        {
            //association[i] = 35;
            choixAssos = 35;
            Debug.Log("4e sport");
            SceneManager.LoadScene(1);
        }

        if (temp == 36)   // wei
        {
            //association[i] = 36;
            choixAssos = 36;
            Debug.Log("wei");
            SceneManager.LoadScene(1);
        }

        if (temp == 37)   // gala
        {
            //association[i] = 37;
            choixAssos = 37;
            Debug.Log("gala");
            SceneManager.LoadScene(1);
        }

        if (temp == 38)   // ice
        {
            //association[i] = 38;
            choixAssos = 38;
            Debug.Log("ice");
            SceneManager.LoadScene(1);
        }

        if (temp == 39)   // microsoft
        {
            //association[i] = 39;
            choixAssos = 39;
            Debug.Log("microsoft");
            SceneManager.LoadScene(1);
        }

        if (temp == 40)   // 3d
        {
            //association[i] = 40;
            choixAssos = 40;
            Debug.Log("3d");
            SceneManager.LoadScene(1);
        }

        if (temp == 41)   // crobotic
        {
            //association[i] = 41;
            choixAssos = 41;
            Debug.Log("crobotic");
            SceneManager.LoadScene(1);
        }

        if (temp == 42)   // linux
        {
            //association[i] = 42;
            choixAssos = 42;
            Debug.Log("linux");
            SceneManager.LoadScene(1);
        }

        if (temp == 43)   // aero
        {
            //association[i] = 43;
            choixAssos = 43;
            Debug.Log("aero");
            SceneManager.LoadScene(1);
        }

        if (temp == 44)   // get
        {
            //association[i] = 44;
            choixAssos =44 ;
            Debug.Log("get");
            SceneManager.LoadScene(1);
        }

        if (temp == 45)   // crypto
        {
            //association[i] = 45;
            choixAssos = 45;
            Debug.Log("crypto");
            SceneManager.LoadScene(1);
        }

        if (temp == 46)   // fap
        {
            //association[i] = 46;
            choixAssos = 46;
            Debug.Log("fap");
            SceneManager.LoadScene(1);
        }

        if (temp == 47)   // eah
        {
            //association[i] = 47;
            choixAssos = 47;
            Debug.Log("eah");
            SceneManager.LoadScene(1);
        }

        if (temp == 48)   // symbioz
        {
            //association[i] = 48;
            choixAssos = 48;
            Debug.Log("symbioz");
            SceneManager.LoadScene(1);
        }

        if (temp == 49)   // entraide
        {
            //association[i] = 49;
            choixAssos = 49;
            Debug.Log("entraide");
            SceneManager.LoadScene(1);
        }

        if (temp == 50)   // human app
        {
            //association[i] = 50;
            choixAssos = 50;
            Debug.Log("human app");
            SceneManager.LoadScene(1);
        }

        if (temp == 51)   // 4L
        {
            //association[i] = 51;
            choixAssos = 51;
            Debug.Log("4L");
            SceneManager.LoadScene(1);
        }



    }



   

    /*  int FindLastAssos()
      {
          int i = 0;

          while (association[i] != 0 && i < 3)
              i++;
          if (i == 2)
              return -1;
          else
              return i;
      }*/


}