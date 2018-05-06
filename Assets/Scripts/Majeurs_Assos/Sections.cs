﻿using UnityEngine;

public class Sections : MonoBehaviour
{
    public GameObject classique;
    public GameObject inter;
    public GameObject bio;
    public GameObject renforce;

    string choixSection;

    private int bac;
    private int langue;
    private Sauvegarde save;

    public void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        bac = save.Get_bac();

        classique.SetActive(false);
        inter.SetActive(false);
        bio.SetActive(false);
        renforce.SetActive(false);


        //Debug.Log("langue " + langue);

        if (bac == 1)
        {
            renforce.SetActive(true);
        }
        else if (bac == 0)
        {
            classique.SetActive(true);
            inter.SetActive(true);
            bio.SetActive(true);
        }
    }

    


    public void Choice(int temp)
    {
        switch (temp)
        {
            case 1:
                choixSection = "Prépa Scientifique";
                break;

            case 2:
                choixSection = "Prépa Scientifique Section Internationale";
                langue = 1;
                break;

            case 3:
                choixSection = "Prépa Biologie et Numérique";
                break;

            case 4:
                choixSection = "Prépa Rénforcée";
                break;
                
        }

        save.Set_section(choixSection);
        save.Set_langue(langue);
        save.Save_Parameters();
        //StartCoroutine(save.Load_scenes(0.8f));
        save.Disp_after_Stop("Menu Sections");
    }
}