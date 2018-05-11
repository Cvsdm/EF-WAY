using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour {

    public Text diplome_Titre, diplome_text, job_titre, job_text, jet_text;
    public GameObject diplome, job, jetons, jet_btn;
    private Sauvegarde save;
    private int jet = 0;

	void Start ()
    {
        save = FindObjectOfType<Sauvegarde>();
        jet = save.Get_jetons();
		if (save.Get_langue() == 0)
        {
            diplome_Titre.text = "Ton Diplome : ";
            diplome_text.text = "Section : " + save.Get_section() + 
                        "\nMajeure : " + save.Get_majeure() + 
                        "\nTa destination : " + save.Get_destination() +
                        "\nTes associations : \n" + Get_sub_assos() +
                        "Tes points accumulés : " + Get_points();

            job_titre.text = "Les métiers qui te correspondent sont : ";
            job_text.text = "A completer !! :D";

            jet_text.text = "Vous avez gagné " + jet + " jetons ! \n\n Il vous en reste : " + save.Get_jetons();
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
        }
	}

    private void Update() // update pr les jetons !! :D
    {
        
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

}
