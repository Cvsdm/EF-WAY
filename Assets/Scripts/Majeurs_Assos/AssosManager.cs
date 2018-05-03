using UnityEngine;
using UnityEngine.UI;

public class AssosManager : MonoBehaviour
{
    //Menu
    public Text text_1, text_1_2, text_2, text_2_2, text_3, text_3_2, text_4, text_4_2, text_5, text_5_2, text_6, text_6_2, text_7, text_7_2, text_8, text_8_2, text_9, text_9_2;

    //Pro
    public Text text_10_2, text_11_2, text_12_2, text_13_2, text_14_2;

    //Media
    public Text text_15_2, text_16_2, text_17_2;

    //Inter
    public Text text_18_2, text_19_2, text_20_2, text_21_2;

    //Culture
    public Text text_22_2, text_23_2, text_24_2, text_25_2, text_26_2, text_27_2, text_28_2, text_29_2, text_30_2, text_31_2, text_32_2, text_61_2, text_62_2, text_63_2;

    //Sport
    public Text text_33, text_33_2, text_34_2, text_35_2, /*text_36, text_36_2,*/ text_37_2, text_38_2, text_39_2, text_40_2, text_41_2, text_42_2, text_43_2;

    //Events
    public Text text_45_2, text_46_2;

    //Technique
    public Text text_47_2, text_48_2, text_49_2, text_50_2, text_51_2, text_52_2, /*text_53, text_53_2,*/ text_54_2;

    //Entraide
    public Text text_55_2, text_56_2, text_57_2, /*text_58, text_58_2,*/ text_59_2, text_60_2;

    public Text bureauBDS;
    public Text displayAssos;


    private string choixAssos;
    private int langue;
    private Sauvegarde save;

    public void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        langue = save.Get_langue();

        if (langue == 0)
        {
            IniFrench();
        }
        else if (langue == 1)
        {
            IniEnglish();
        }
    }

    void IniFrench()
    {
        // Menu
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
        text_10_2.text = "Junior Entreprise";
        text_11_2.text = "EFrei FORmation\nFormations et réalisation de prestations techniques dans le domaine des nouvelles technologies";
        text_12_2.text = "Entraine les élèves à parler à l'oral avec éloquence";
        text_13_2.text = "Portail d'Information pour les Stages en Entreprises\nCV\nCampus day\nConférences";
        text_14_2.text = "Association des ingénieurs du groupe EFREI pour actuels et anciens étudiants";

        // Assos media
        text_15_2.text = "EFREI Picture Studio\nAssociation de photos et vidéos\nCouvre tous les événements du campus";
        text_16_2.text = "Journal des étudiants\nLien entre élèves, administration et associations";
        text_17_2.text = "Radio de l'école\nInterview, événements, activités, musique";

        // Assos inter
        text_18_2.text = "Acceuille les élèves étrangers qui intègre l'Efrei Paris\nRusses, chinois, allemands, australiens, indiens...";
        text_19_2.text = "Consacrée à la découverte des cultures asiatiques";
        text_20_2.text = "Acceuille les élèves d'écoles et universités partenaires";
        text_21_2.text = "Consacrée à la culture maghrébine au sein du campus";

        // Assos Culture et loisirs
        text_22_2.text = "Spectacles, sketches, représentations étudiantes et humoristes";
        text_23_2.text = "Consacrée aux instruments de musiques\nReprésentations, cours,...";
        text_24_2.text = "Organise le Rézal : 24heures non stop de jeux, tournois, musique sur le campus";
        text_25_2.text = "Propose de pratiquer le poker, apprendre ou se perfectionner";
        text_26_2.text = "Jeux de cartes, rôles, tournois ...";
        text_27_2.text = "Initiation à la dégustation de vins";
        text_28_2.text = "Scénarise et donne vie à des Escape Games sur le campus";
        text_29_2.text = "Club de dessin\nIllustration du journal de l'école, sorties culturelles ...";
        text_30_2.text = "Gestion de la K-fet, rénovation, entretien ...\nEspace de détente, soirée, projection...";
        text_31_2.text = "Apprendre les rudiments essentiels de la cuisine orienté étudiante";
        text_32_2.text = "Association de DJ\nMixage, éclairage pendant les événements\nProduction de musique";
        text_61_2.text = "Jeux vidéos rétro";
        text_62_2.text = "Emmène les étudiants au théâtre, à l'opéra, et dans d’autres lieux insolites de Paris";
        text_63_2.text = "Association de magie\nManipulation l'histoire et tours";

        // Sports
        text_33.text = "Bureau des Sports (BDS)";
        text_33_2.text = "Football, rugby, basketball, badminton, tennis, natation";
        text_34_2.text = "Hip hop, capoeira, salsa, break dance";
        text_35_2.text = "Dédié aux sports de combat\nPratique des arts martiaux\nCours d'autodéfense";
        // text_36.text = "EF Racing";
        // text_36_2.text = "Association de karting et automobile";
        text_37_2.text = "Glisse urbaine : cyclisme, planches, roller...\nGlisse aquatique : wakeboard, windsurf, kitesurf, speed sail";
        text_38_2.text = "Initiation à la voile\nReprésente l'école à la course croisière EDHEC";
        text_39_2.text = "Association d'escalade";
        text_40_2.text = "Fais découvrir la chute libre avec l'association de parachutisme";
        text_41_2.text = "Pour les passionnés de Laser Game\nAffrontements organisés après les cours dans le Laser Game Evolution de Paris 14";
        text_42_2.text = "Compétitions internationales de hockey sur glace";
        text_43_2.text = "Pour les passionnés d'e-sport qui souhaitent intégrer une équipe e-sportive\nTournois et LAN";

        //Events
        text_45_2.text = "Associaiton qui accueille les nouveaux étudiants\nEvénements organisés pendant lors du mois d'arrivée (petit déjeuner, rallye culturel, barbecue, soirées...)";
        text_46_2.text = "Etudiants, diplômés, membres de l'administration..\nTous invités dans une grande salle parisienne pour une soirée d'exception";

        //Technique
        text_47_2.text = "Possibilité d'approfondir les connaissances techniques et mener des projets Recherche & Développement sur les technologies de l'information et de la communicaiton";
        text_48_2.text = "Prend la forme d'un Student Club\nDédié aux technologies Microsoft\nConférences, formations...";
        text_49_2.text = "Intéressés par la modélisation et l'animation 3D\nFormations, interventions de spécialistes...\nOutils nécéssaires pour la réalisation";
        text_50_2.text = "Représente l'école à la Coupe de France de Robotique\nAssociation de robotique";
        text_51_2.text = "Dédiée au logiciel libre\nFormations, Install Party...";
        text_52_2.text = "Rassemble les élèves passionnés d'aéronotique\n3 pôles : formation, espace, aéronautique\nSimulateurs, ballons sondes...";
        //text_53.text = "GET";
        //text_53_2.text = "Consacrée aux technologies du web\nGoodle AdWords, Android, Gmail, GWT, SEO, Google Apples...";
        text_54_2.text = "Vulgarise et aide les personnes à s'intéresser à la crypto monnaie";

        //Entraide
        text_55_2.text = "Rends accessibles les technologies de l'information au plus grand nombre\nPersonnes âgées, légèrement handicapées, collégiens";
        text_56_2.text = "Favorise l'égalité de l'accès à l'éducation\nConvois humanitaires (Burkina, Madagascar, Sénégal, Rwanda...)";
        text_57_2.text = "Actions de terrain contre l'impact environnemental de l'industrie indormatique\nTri sélectif, collectes de piles...";
        //text_58.text = "Entraide";
        //text_58_2.text = "Promeut l'entraide entre les élèves du groupe\nFormations entre élèves";
        text_59_2.text = "Développe des applications à destiation des personnes âgées, ONG humanitaires...\nLigue contre le cancer\nRelation avec l'hôpital Paul Brousse";
        text_60_2.text = "Participe au 4L Trophy\nRaid automobile humanitaire destiné aux étudiants";

        bureauBDS.text = "Bureau du BDS";
        
    }

    void IniEnglish()
    {
        // Menu
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
        text_10_2.text = "Junior Entreprise";
        text_11_2.text = "EFrei FORmation\nTrainings and technic implementation in new technologies";
        text_12_2.text = "Trains students to talk in public with eloquence";
        text_13_2.text = "Portal of information for firms' internships\nCV\nCampus day\nConferences";
        text_14_2.text = "Association of actual and former students in EFREI";

        // Assos media
        text_15_2.text = "EFREI Picture Studio\nAssociation dedicated to pictures and videos\nCovers every events of the school";
        text_16_2.text = "Newspaper of the students\nLink between students, administration and associations";
        text_17_2.text = "Radio of the school\nInterviews, events, activities, music";

        // Assos inter
        text_18_2.text = "Welcomes foreigners students that come to study in Efrei Paris\nRussians, Chinese, Germans, Australiens, Indians...";
        text_19_2.text = "Dedicated to the discovery of Asian culture";
        text_20_2.text = "Welcomes foreigners students from partners universities and schools";
        text_21_2.text = "Dedicated to the discovery of culture of the Maghreb";

        // Assos Culture et loisirs
        text_22_2.text = "Shows, stand ups, performances by students and comedians";
        text_23_2.text = "Dedicated to musical instruments\nPerformances, courses,...";
        text_24_2.text = "Organizes the 'Rézal' : 24hours non stop of gaming, tournaments, music on campus";
        text_25_2.text = "Offers to learn poker, train or perfect the art";
        text_26_2.text = "Cards games, role plays, tournaments...";
        text_27_2.text = "Initiation to wine tasting";
        text_28_2.text = "Creates Escape Games on campus";
        text_29_2.text = "Drawing club\nIllustrates the school newspaper, cultural hangouts ...";
        text_30_2.text = "Manages the K-fet, the renovation, the maintenance...\nRoom to relax, party,...";
        text_31_2.text = "Learn the basics to cooking for a student";
        text_32_2.text = "Association of DJ\nMixing, spotlights during events\nMusic production";
        text_61_2.text = "Old school video games";
        text_62_2.text = "Takes students to the theater, opera and other unusual places in Paris";
        text_63_2.text = "Magic association\nManipulation, history and tricks";

        // Sports
        text_33.text = "Sports Office (BDS)";
        text_33_2.text = "Football, rugby, basketball, badminton, tennis, swimming";
        text_34_2.text = "Hip hop, capoeira, salsa, breakdance";
        text_35_2.text = "Dedicated to combat sports\nPractice martial arts\nClasses of self defense";
        //   text_36.text = "EF Racing";
        //  text_36_2.text = "Association of karting and automobile";
        text_37_2.text = "Cyycling, board sports, roller blading, wakeboard, windsurfing, kitesurf, speed sail";
        text_38_2.text = "Initiation to sailing\nRepresents the school for the Cruise Race EDHEC";
        text_39_2.text = "Climbing association";
        text_40_2.text = "Discover free fall with the skydiving associaiton";
        text_41_2.text = "For lovers of Game Tags\nBattles organized after classes in the Game Tag Evolution Paris 14";
        text_42_2.text = "International hockey on ice competition";
        text_43_2.text = "For lovers of e-sports who wish to join a team\nTournaments and LAN parties";

        //Events
        text_45_2.text = "Association with the goal of welcoming new students\nMany events organized during their first month : breakfast, cultural rally, Sidaction day, barbecue, parties...";
        text_46_2.text = "Students, graduates, members of the administration...\nAll invited to a huge Parisian ball room for a night to remember";

        //Technique
        text_47_2.text = "Possibility to widden the knowledge and lead project in Research & Developpement on information technologies and communication";
        text_48_2.text = "Takes the form of a Student Club\nDedicated to Microsoft technologies\nConferences, courses...";
        text_49_2.text = "For those interessed in 3D modelisation and animation\nCourses, specialists conferences...\nTools available for production";
        text_50_2.text = "Represents the school for the 'Coupe de France de Robotique'\nRobotics association";
        text_51_2.text = "Dedicated to free software\nCourses, Install Parties...";
        text_52_2.text = "Gathers lovers of aeronautics\n3 poles : courses, space, aeraunotics\nSimulators, sounding ballon...";
        //   text_53.text = "GET";
        //  text_53_2.text = "Dedicated to new technologies of the web\nGoodle AdWords, Android, Gmail, GWT, SEO, Google Apps...";
        text_54_2.text = "Popularizes and help people take an interest in crypto currency";

        //Entraide
        text_55_2.text = "Makes available information technologies to people\nElderly, slightly handicapped, students";
        text_56_2.text = "Improves the equality of the education access\nHumanitarian convoys (Burkina, Madagascar, Senegal, Rwanda...)";
        text_57_2.text = "Field action against the impact of environmental Impact of IT \nRecycling, collection bins of used batteries";
        //text_58.text = "Entraide";
        // text_58_2.text = "Promotes the mutual aid between students of the group\nCourses between students";
        text_59_2.text = "Developps apps for elderly, hospitals and NGO\nCancer Ligue\nLinks with the Paul Brousse hospital";
        text_60_2.text = "Takes part in the 4L Trophy\nHumanitarian automobile raid dedicated to students";

        bureauBDS.text = "Sports Office";
        
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
            case 1:  //BDE
            choixAssos = "BDE";
                break;

            case 2:   // Sepefrei
            choixAssos = "Sepefrei";
                break;

            case 3:   // Effor
            choixAssos = "EFFOR";
                break;

            case 4:   // Ogma
            choixAssos = "Ogma";
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

        if (!save.Found_assos(choixAssos))
        {
            save.Add_assos(choixAssos);
            save.Save_Parameters();

            if (langue == 0)
                displayAssos.text = "Tu as choisi : " + choixAssos;
            else
                displayAssos.text = "You chose : " + choixAssos;
        }
    }
}
