﻿using UnityEngine;
using UnityEngine.UI;

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
    public Text text_22, text_22_2, text_23, text_23_2, text_24, text_24_2, text_25, text_25_2, text_26, text_26_2, text_27, text_27_2, text_28, text_28_2, text_29, text_29_2, text_30, text_30_2, text_31, text_31_2, text_32, text_32_2, text_61, text_61_2, text_62, text_62_2, text_63, text_63_2;
    public Sprite sprite22, sprite23, sprite24, sprite25, sprite26, sprite27, sprite28, sprite29, sprite30, sprite31, sprite32, sprite61, sprite62, sprite63;
    public Image image22, image23, image24, image25, image26, image27, image28, image29, image30, image31, image32, image61, image62, image63;

    //Sport
    public Text text_33, text_33_2, text_34, text_34_2, text_35, text_35_2, /*text_36, text_36_2,*/ text_37, text_37_2, text_38, text_38_2, text_39, text_39_2, text_40, text_40_2, text_41, text_41_2, text_42, text_42_2, text_43, text_43_2;
    public Sprite sprite33, sprite34, sprite35, /*sprite36,*/ sprite37, sprite38, sprite39, sprite40, sprite41, sprite42, sprite43;
    public Image image33, image34, image35, /*image36,*/ image37, image38, image39, image40, image41, image42, image43;

    //Events
    public Text text_45, text_45_2, text_46, text_46_2;
    public Sprite sprite45, sprite46;
    public Image image45, image46;

    //Technique
    public Text text_47, text_47_2, text_48, text_48_2, text_49, text_49_2, text_50, text_50_2, text_51, text_51_2, text_52, text_52_2, /*text_53, text_53_2,*/ text_54, text_54_2;
    public Sprite sprite47, sprite48, sprite49, sprite50, sprite51, sprite52, /*sprite53, */sprite54;
    public Image image47, image48, image49, image50, image51, image52,/* image53,*/ image54;

    //Entraide
    public Text text_55, text_55_2, text_56, text_56_2, text_57, text_57_2, /*text_58, text_58_2,*/ text_59, text_59_2, text_60, text_60_2;
    public Sprite sprite55, sprite56, sprite57, /*sprite58,*/ sprite59, sprite60;
    public Image image55, image56, image57, /*image58,*/ image59, image60;

    // BDS
    public Text text_64, text_65, text_66, text_67, text_68, text_69, text_70, text_71, text_72, text_73;
    public Sprite sprite64, sprite65, sprite66, sprite67, sprite68, sprite69, sprite70, sprite71, sprite72, sprite73;
    public Image image64, image65, image66, image67, image68, image69, image70, image71, image72, image73;

    private string choixAssos;
    private int langue;
    private Sauvegarde save;

    public void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        langue = save.Get_langue();
        IniVariables();

        if (langue == 0)
        {
            IniFrench();
        }
        else if (langue == 1)
        {
            IniEnglish();
        }
    }

    void IniVariables()
    {
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
        // image36.sprite = sprite36;
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
        //  image53.sprite = sprite53;
        image54.sprite = sprite54;
        image55.sprite = sprite55;
        image56.sprite = sprite56;
        image57.sprite = sprite57;
        //  image58.sprite = sprite58;
        image59.sprite = sprite59;
        image60.sprite = sprite60;
        image61.sprite = sprite61;
        image62.sprite = sprite62;
        image63.sprite = sprite63;
        image64.sprite = sprite64;
        image65.sprite = sprite65;
        image66.sprite = sprite66;
        image67.sprite = sprite67;
        image68.sprite = sprite68;
        image69.sprite = sprite69;
        image70.sprite = sprite70;
        image71.sprite = sprite71;
        image72.sprite = sprite72;
        image73.sprite = sprite73;
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
        text_12.text = "Ogma";
        text_12_2.text = "Entraine les élèves à parler à l'oral avec éloquence";
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
        text_61.text = "Pandora";
        text_61_2.text = "Héhé, bonne question ^^";
        text_62.text = "Spot";
        text_62_2.text = "Emmène les étudiants au théâtre, à l'opéra, et dans d’autres lieux insolites de Paris";
        text_63.text = "The Mist";
        text_63_2.text = "Association de magie\nManipulation l'histoire et tours";

        // Sports
        text_33.text = "Bureau des Sports (BDS)";
        text_33_2.text = "Football, rugby, basketball, badminton, tennis, natation";
        text_34.text = "Efreestyle";
        text_34_2.text = "Hip hop, capoeira, salsa, break dance";
        text_35.text = "Efight";
        text_35_2.text = "Dédié aux sports de combat\nPratique des arts martiaux\nCours d'autodéfense";
        // text_36.text = "EF Racing";
        // text_36_2.text = "Association de karting et automobile";
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
        //text_53.text = "GET";
        //text_53_2.text = "Consacrée aux technologies du web\nGoodle AdWords, Android, Gmail, GWT, SEO, Google Apples...";
        text_54.text = "EFREI Crypto Paris";
        text_54_2.text = "Vulgarise et aide les personnes à s'intéresser à la crypto monnaie";

        //Entraide
        text_55.text = "Formation Aux Particuliers (FAP)";
        text_55_2.text = "Rends accessibles les technologies de l'information au plus grand nombre\nPersonnes âgées, légèrement handicapées, collégiens";
        text_56.text = "EFREI Aides Humanitaires (EAH)";
        text_56_2.text = "Favorise l'égalité de l'accès à l'éducation\nConvois humanitaires (Burkina, Madagascar, Sénégal, Rwanda...)";
        text_57.text = "Symbioz EFREI";
        text_57_2.text = "Actions de terrain contre l'impact environnemental de l'industrie indormatique\nTri sélectif, collectes de piles...";
        //text_58.text = "Entraide";
        //text_58_2.text = "Promeut l'entraide entre les élèves du groupe\nFormations entre élèves";
        text_59.text = "Human'App";
        text_59_2.text = "Développe des applications à destiation des personnes âgées, ONG humanitaires...\nLigue contre le cancer\nRelation avec l'hôpital Paul Brousse";
        text_60.text = "4L & FAONS";
        text_60_2.text = "Participe au 4L Trophy\nRaid automobile humanitaire destiné aux étudiants";

        //BDS
        text_64.text = "Bureau du BDS";
        text_65.text = "Efrei Athlé";
        text_66.text = "Echecs Groupe EFREI (EGE)";
        text_67.text = "Football EFREI";
        text_68.text = "EFREI Tennis";
        text_69.text = "Eswim";
        text_70.text = "EFREI Basket";
        text_71.text = "Rugbiere";
        text_72.text = "EFREI Badminton";
        text_73.text = "EFREI Volley";
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
        text_12.text = "Ogma";
        text_12_2.text = "Trains students to talk in public with eloquence";
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
        text_61.text = "Pandora";
        text_61_2.text = "Héhé, bonne question ^^";
        text_62.text = "Spot";
        text_62_2.text = "Takes students to the theater, opera and other unusual places in Paris";
        text_63.text = "The Mist";
        text_63_2.text = "Magic association\nManipulation, history and tricks";

        // Sports
        text_33.text = "Bureau des Sports (BDS)";
        text_33_2.text = "Football, rugby, basketball, badminton, tennis, swimming";
        text_34.text = "Efreestyle";
        text_34_2.text = "Hip hop, capoeira, salsa, breakdance";
        text_35.text = "Efight";
        text_35_2.text = "Dedicated to combat sports\nPractice martial arts\nClasses of self defense";
        //   text_36.text = "EF Racing";
        //  text_36_2.text = "Association of karting and automobile";
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
        //   text_53.text = "GET";
        //  text_53_2.text = "Dedicated to new technologies of the web\nGoodle AdWords, Android, Gmail, GWT, SEO, Google Apps...";
        text_54.text = "EFREI Crypto Paris";
        text_54_2.text = "Popularizes and help people take an interest in crypto currency";

        //Entraide
        text_55.text = "Formation Aux Particuliers (FAP)";
        text_55_2.text = "Makes available information technologies to people\nElderly, slightly handicapped, students";
        text_56.text = "EFREI Aides Humanitaires (EAH)";
        text_56_2.text = "Improves the equality of the education access\nHumanitarian convoys (Burkina, Madagascar, Senegal, Rwanda...)";
        text_57.text = "Symbioz EFREI";
        text_57_2.text = "Field action against the impact of environmental Impact of IT \nRecycling, collection bins of used batteries";
        //text_58.text = "Entraide";
        // text_58_2.text = "Promotes the mutual aid between students of the group\nCourses between students";
        text_59.text = "Human'App";
        text_59_2.text = "Developps apps for elderly, hospitals and NGO\nCancer Ligue\nLinks with the Paul Brousse hospital";
        text_60.text = "4L & FAONS";
        text_60_2.text = "Takes part in the 4L Trophy\nHumanitarian automobile raid dedicated to students";


        //BDS
        text_64.text = "Bureau du BDS";
        text_65.text = "Efrei Athlé";
        text_66.text = "Echecs Groupe EFREI (EGE)";
        text_67.text = "Football EFREI";
        text_68.text = "EFREI Tennis";
        text_69.text = "Eswim";
        text_70.text = "EFREI Basket";
        text_71.text = "Rugbiere";
        text_72.text = "EFREI Badminton";
        text_73.text = "EFREI Volley";
    }



    public void ChangeLanguageToEn()
    {
        langue = 1;
        IniEnglish();
    }

    public void ChangeLanguageToFr()
    {
        langue = 0;
        IniFrench();
    }

    public void Choice(int temp)
    {
        switch (temp)
        {
            case 1: 
            choixAssos = "BDE";
                break;

            case 2:   // Sepefrei
            choixAssos = "Sepefrei";
                break;

            case 3:   // Effor
            choixAssos = "EFFOR";
                break;

            case 4:   // Effi
            choixAssos = "Effi";
                break;

            case 5:   // Piste
            choixAssos = "Piste";
                break;

            case 6:   // AI EFREI
            choixAssos = "AI efrei";
                break;

            case 7:   // EPS
            choixAssos = "EPS";
                break;

            case 8:   // Rename
            choixAssos = "Rename";
                break;

            case 9:   // Ready o
            choixAssos = "Ready o";
                break;

            case 10:   // Efrei int
            choixAssos = "Efrei international";
                break;

            case 11:   // Asian
            choixAssos = "Asian";
                break;

            case 12:   // I week
            choixAssos = "I week";
                break;

            case 13:   // Infitah
            choixAssos = "Infitah";
                break;

            case 14:   // Yé mistikrirk
            choixAssos = "Ye Mistikrik";
                break;

            case 15:   // Live Efrei
            choixAssos = "Live Efrei";
                break;

            case 16:   // Club Rézo
            choixAssos = "Club Rézo";
                break;


            case 17:   // Efrei Poker
            choixAssos = "Efrei Poker";
                break;

            case 18:   // Taverne
            choixAssos = "Taverne";
                break;

            case 19:   // Millésisme
            choixAssos = "Millésisme";
                break;

            case 20:   // Groupe Escape
            choixAssos = "Groupe Escape";
                break;

            case 21:   // Pen soul
            choixAssos = "Pen Soul";
                break;

            case 22:   // Le Continental
            choixAssos = "Continental";
                break;

            case 23:   // EfreiChef
            choixAssos = "Efrei Chefs";
                break;

            case 24:   // Hifi Lix
            choixAssos = "Hifi Lix";
                break;

            case 25:   // bds
            choixAssos = "bds";
                break;

            case 26:   // efreestyle
            choixAssos = "efreestyle";
                break;

            case 27:   // efight
            choixAssos = "efight";
                break;

            case 28:   // ef racing
            choixAssos = "ef racing";
                break;

            case 29:   // ef ride
            choixAssos = "ef ride";
                break;

            case 30:   // cap efrei
            choixAssos = "cap efrei";
                break;

            case 31:   // efrei climbing
            choixAssos = "climbing";
                break;

            case 32:   // para
            choixAssos = "para";
                break;

            case 33:   // efray
            choixAssos = "efray";
                break;

            case 34:   // hock
            choixAssos = "Hock'Efrei";
                break;

            case 35:   // 4e sport
            choixAssos = "4e sport";
                break;

        case 36:   // wei
            choixAssos = "wei";
                break;

            case 37:   // gala
            choixAssos = "Gala";
                break;

            case 38:   // ice
            choixAssos = "ice";
                break;

            case 39:   // microsoft
            choixAssos = "Microsoft";
                break;

            case 40:   // 3d
            choixAssos = "3d";
                break;

            case 41:   // crobotic
            choixAssos = "crobotic";
                break;

            case 42:   // linux
            choixAssos = "linux";
                break;

            case 43:   // aero
            choixAssos = "aero";
                break;

            case 44:   // get
            choixAssos = "get";
                break;

            case 45:   // crypto
            choixAssos = "crypto";
                break;

            case 46:   // fap
            choixAssos = "fap";
                break;

            case 47:   // eah
            choixAssos = "eah";
                break;

            case 48:   // symbioz
            choixAssos = "symbioz";
                break;

            case 49:   // entraide
            choixAssos = "entraide";
                break;

            case 50:   // human app
            choixAssos = "human app";
                break;

            case 51:   // 4L       
            choixAssos = "4L";
                break;

            case 52:   // Spot
                    choixAssos ="Spot";
                break;

            case 53: // Mist
                    choixAssos ="Mist";
                break;

            case 54:  // Bureau BDS
                    choixAssos ="Bureau BDS";
                break;

            case 55:  // Athlé
                    choixAssos ="Athlé";
                break;

            case 56:  // EGE
                    choixAssos ="EGE";
                break;

            case 57:  // Foot
                    choixAssos ="Foot";
                break;

            case 58:  // Tennis
                    choixAssos ="Tennis";
                break;

            case 59:  // Natation
                    choixAssos ="Natation";
                break;

            case 60:  // Basket
                    choixAssos ="Basket";
                break;

            case 61:  // Rugby
                    choixAssos ="Rugby";
                break;

            case 62:  // Bad
                    choixAssos ="Bad";
                break;

            case 63:  // Volley
                    choixAssos ="Volley";
                break;

            case 64:  // Pandora
                    choixAssos ="Pandora";
                break;
        }
        
        save.Add_assos(choixAssos);
        save.Save_Parameters();
    }
}
