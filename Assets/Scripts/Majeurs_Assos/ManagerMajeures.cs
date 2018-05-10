using UnityEngine;
using UnityEngine.UI;

public class ManagerMajeures : MonoBehaviour
{
    public Text text_BI1;   // Business intelligence
    public Text text_BI2;

    public Text text_ISCC1;     //Information System and Cloud Computing
    public Text text_ISCC2;

    public Text text_VR1;       //Imagerie et réalité virtuelle
    public Text text_VR2;

    public Text text_BD1;       // Big data
    public Text text_BD2;

    public Text text_F1;        // Finance
    public Text text_F2;

    public Text text_Secu1;     // Sécurité
    public Text text_Secu2;

    public Text text_IL1;       // Ingéniérie logicielle
    public Text text_IL2;

    public Text text_B1;        // Bio informatique
    public Text text_B2;

    public Text text_AE1;       // Avionique et espaces
    public Text text_AE2;

    public Text text_DD1;       // Droides et drones
    public Text text_DD2;

    public Text text_NV1;       // Network et virtualisation
    public Text text_NV2;

    public Text text_ENRI1;     // Energies nouvelles et réseaux intelligents
    public Text text_ENRI2;
    
    private int langue = 0;
    public Text choice;
    private Sauvegarde save;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
    }

    void MajeuresFR()
    {
        text_BI1.text = "Business Intelligence (Anglais)";
        text_BI2.text = "Informatique décisionnelle \nBase de données \nData mining \nDirection stratégique \nAnalyse";


        text_ISCC1.text = "Information System and Cloud Computing (Anglais)";
        text_ISCC2.text = "Cloud computing \nBuisness process management \nSystème d'information ";

        text_VR1.text = "Imagerie et Réalité Virtuelle (Français)";
        text_VR2.text = "Animation 3D \nVision artificielle \nSystème temps réel\nIA \nOgre3D ";

        text_BD1.text = "Big Data (Anglais)";
        text_BD2.text = "Stockage \nDonnées massives \nStatistiques \nStratégie ";

        text_ENRI1.text = "Energies Nouvelles et Réseaux Intelligents (Français)";
        text_ENRI2.text = "Smart-Grid \nBesoins énergétiques \nEnvironnement \nEnergies renouvelables \nSmart buildings \nGreen IT ";

        text_Secu1.text = "Sécurité des SI (Français & Anglais)";
        text_Secu2.text = "Réseau \nProtection système \nSécurité d'information \nFirewall \nDroit informatique";

        text_IL1.text = "Ingéniérie Logicielle (Anglais)";
        text_IL2.text = "Conception d'application \nTemps réel \nModélisation \nDévelopement \nAlgorithmie \nWeb \nTechno objet ";

        text_B1.text = "Bio-Informatique (Français)";
        text_B2.text = "Biotechnologie \nBig data \nE - santé";

        text_AE1.text = "Avionique et Espaces (Français)";
        text_AE2.text = "Systèmes radio et communication \nSystèmes de navigation \nGPS \nRadars \nCalculateurs embarqués ";

        text_DD1.text = "Droïdes et Drones (Français)";
        text_DD2.text = "Humanoïdes \nSystème embarqué \nIntelligence embarquée \nSurveillance \nSécurité \nAide à la personne ";

        text_NV1.text = "Network et Virtualisation (Anglais)";
        text_NV2.text = "Stockage des données \nSécurisation des données \nGreen IT \nData - centers \nCloud computing \nRéseaux ";

        text_F1.text = "IT For Finance (Anglais)";
        text_F2.text = "Modélisation Mathématique \nSimulation Numérique \nCalcul haute performance \nEtude de marché ";
    }

    void MajeuresEN()
    {
        text_BI1.text = "Business Intelligence (English)";
        text_BI2.text = "Business analysis \nDatabases \nData mining \nStrategic direction \nAnalytics ";


        text_ISCC1.text = "Information System and Cloud Computing (English)";
        text_ISCC2.text = "Cloud computing \nBuisness process management \nInformation system ";

        text_VR1.text = "Imaging & Virtual Reality (French)";
        text_VR2.text = "3D Animation \nComputer vision \nReal-time computing \nAI \nOgre3D ";

        text_BD1.text = "Big Data (Anglais)";
        text_BD2.text = "Data analysis \nDatabases \nMachine learning \nOptimisation \nAI ";

        text_ENRI1.text = "Renewable Energies and Smart Grids (French)";
        text_ENRI2.text = "Intelligent networks \nUrban energy management \nReal-time regional energy management ";

        text_Secu1.text = "Security (French & English)";
        text_Secu2.text = "Network \nSystem protection \nInformation security \nFirewalls \nIT law ";

        text_IL1.text = "Software Engineering (English)";
        text_IL2.text = "Application design \nModelling \nDevelopment \nAlgorithmics \nThe web \nObject-oriented technologies ";

        text_B1.text = "Bioinformatics (French)";
        text_B2.text = "Biotechnologies \nBig data ";

        text_AE1.text = "Avionics and Space (French)";
        text_AE2.text = "Mobile and spatial communication \nGeolocation \nNavigation ";

        text_DD1.text = "Droids and Drones (French)";
        text_DD2.text = "Elbedded intelligence \nAutonomous systems ";

        text_NV1.text = "Networks and Virtualisation (English)";
        text_NV2.text = "Data centers \nCloud computing ";

        text_F1.text = "IT For Finance (English)";
        text_F2.text = "Mathematical modelling \nNumerical simulation \nHigh-performance computing \nMarket Research ";
    }

    void Update()
    {
        if (langue == 1)
        {
            MajeuresFR();
        }
        else
        {
            MajeuresEN();
        }
    }

    public void ChangeLanguageToEn()
    {
        langue = 2;
    }

    public void ChangeLanguageToFr()
    {
        langue = 1;
    }

    public void ChoixMajeure (int ChoixM)
    {
        if (ChoixM == 1)            choice.text = "Choice : BI";
        else if (ChoixM == 2)       choice.text = "Choice : ISCC";
        else if (ChoixM == 3)       choice.text = "Choice : VR";
        else if (ChoixM == 4)       choice.text = "Choice : BD";
        else if (ChoixM == 12)      choice.text = "Choice : F";
        else if (ChoixM == 5)       choice.text = "Choice : S";
        else if (ChoixM == 6)       choice.text = "Choice : IL";
        else if (ChoixM == 7)       choice.text = "Choice : B";
        else if (ChoixM == 8)       choice.text = "Choice : AE";
        else if (ChoixM == 9)       choice.text = "Choice : DD";
        else if (ChoixM == 10)      choice.text = "Choice : NV";
        else if (ChoixM == 11)      choice.text = "Choice : ENRI";

        //Debug.Log("choix : " + ChoixM);
        save.Set_majeure(ChoixM);
        //Debug.Log("choix : " + ChoixM);
    }

    public void Exit_button()
    {
        save.Disp_after_Stop("Choix des majeures");
    }
}