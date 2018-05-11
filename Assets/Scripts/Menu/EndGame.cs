﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public Text diplome_Titre, diplome_text, job_titre, job_text, jet_text_1, jet_text_2, jet_title;
    public GameObject diplome, job, jetons, jet_btn;
    private Sauvegarde save;
    private int jet = 0;
    private Bars bars;

	void Start ()
    {
        save = FindObjectOfType<Sauvegarde>();
        bars = FindObjectOfType<Bars>();
        jet = save.Get_jetons();

		if (save.Get_langue() == 0)
        {
            diplome_Titre.text = "Ton Diplome : ";
            diplome_text.text = "Name : " + save.Get_player() + 
                        "\nSection : " + save.Get_section() + 
                        "\nMajeure : " + save.Get_majeure() + 
                        "\nTa destination : " + save.Get_destination() +
                        "\nTes associations : \n" + Get_sub_assos() +
                        "Tes points accumulés : " + Get_points();

            job_titre.text = "Les métiers qui te correspondent sont : ";
            job_text.text = "A completer !! :D";

            jet_title.text = "Vous avez gagné " + jet + " jetons !";
            jet_text_1.text = "Il vous en reste : " + save.Get_jetons();
            StartCoroutine(Update_Jeton());
            
        }
        else
        {
            diplome_Titre.text = "Your Diploma : ";
            diplome_text.text = "Section : " + save.Get_section() +
                                "\nMajeure : " + save.Get_majeure() +
                                "\nYour destination : " + save.Get_destination()+
                                "\nYour associations : \n" + Get_sub_assos() +
                                "\nYour cumulated points : " + Get_points();

            job_titre.text = "Jobs that would fit you : ";
            job_text.text = "A completer !! :D";
            jet_title.text = "You have earned " + jet + " jetons !";
            jet_text_1.text = "You have " + save.Get_jetons() + " left.";
            StartCoroutine(Update_Jeton());
        }
	}

    IEnumerator Update_Jeton ()
    {
        yield return new WaitForSeconds(2);

        save.Set_jetons(save.Get_jetons() - 1);

        if (save.Get_langue() == 0)
            jet_text_1.text = "Il vous en reste :  " + save.Get_jetons();
        else
            jet_text_1.text = "You have " + save.Get_jetons() + " left.";

        jet_text_2.text = Random_aug();
        jet_text_2.color = Nice_color();

        if (save.Get_jetons() != 0)
            StartCoroutine(Update_Jeton());
        else
            jet_btn.gameObject.SetActive(true);
    }

    private string Get_sub_assos()
    {
        string toreturn = "";

        if (!save.Get_Tab_assos(0).Equals("none"))
            toreturn = "\t" + save.Get_Tab_assos(0) +"\n";
        if (!save.Get_Tab_assos(1).Equals("none"))
            toreturn = toreturn + "\t" + save.Get_Tab_assos(1) + "\n";
        if (!save.Get_Tab_assos(2).Equals("none"))
            toreturn = toreturn + "\t" + save.Get_Tab_assos(2) + "\n";

        return toreturn; 
    }

    private float Get_points()
    {
        return save.Get_assos() + save.Get_etude() + save.Get_sociabilite();
    }

    public void Jet_btn()
    {
        jetons.gameObject.SetActive(false);
        diplome.gameObject.SetActive(true);
    }

    public void Dip_btn()
    {
        diplome.gameObject.SetActive(false);
        job.gameObject.SetActive(true);
    }

    private string Random_aug()
    {
        string toreturn = "";
        float aug = Random.Range(5, 25);
        int jauge = Random.Range(0, 2);

        if (jauge == 0)
        {
            //bars.DealAssosPlus(aug);
            if (save.Get_langue() == 0)
                toreturn = "+" + aug + " dans votre jauge association !";
            else
                toreturn = "+" + aug + " in your association's gauge!";
        }
        else if (jauge == 1)
        {
            //bars.DealEtudePlus(aug);
            if (save.Get_langue() == 0)
                toreturn = "+" + aug + " dans votre jauge étude !";
            else
                toreturn = "+" + aug + " in your study's gauge!";
        }
        else if (jauge == 2)
        {
            //bars.DealSocialPlus(aug);
            if (save.Get_langue() == 0)
                toreturn = "+" + aug + " dans votre jauge sociabilité !";
            else
                toreturn = "+" + aug + " in your sociability's gauge!";
        }

        return toreturn;
    }

    private Color Nice_color ()
    {
        Color toreturn = new Color (1f,1f,1f);
        int color = Random.Range(1, 4);

        switch (color)
        {
            case 1:
                toreturn = new Color (1f, 0.78f, 0.125f); // orange
                break;
            case 2:
                toreturn = new Color(1f, 0.271f, 0.722f); // fushia
                break;
            case 3:
                toreturn = new Color(1f, 0.267f, 0.267f); // red
                break;
            case 4:
                toreturn = new Color(0.42f, 1f, 0.243f); // green
                break;
        }

        return toreturn;
    }
}
