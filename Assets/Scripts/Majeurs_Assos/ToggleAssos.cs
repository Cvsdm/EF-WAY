using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleAssos : MonoBehaviour {

    public GameObject menu;
    public GameObject pro;
    public GameObject media;
    public GameObject inter;
    public GameObject culture;
    public GameObject sport;
    public GameObject events;
    public GameObject technique;
    public GameObject entraide;
    public GameObject bds;

    private void Start()
    {
        menu.SetActive(true); 
        pro.SetActive(false);
        media.SetActive(false);
        inter.SetActive(false);
        culture.SetActive(false);
        sport.SetActive(false);
        events.SetActive(false);
        technique.SetActive(false);
        entraide.SetActive(false);
        bds.SetActive(false);
    }

    public void ToggleMenu()    //toggle on or off the pause menu
    {
        menu.SetActive(!menu.activeSelf); 
    }

    public void TogglePro()    
    {
        pro.SetActive(!pro.activeSelf); 
    }

    public void ToggleMedia()
    {
        media.SetActive(!media.activeSelf);
    }

    public void ToggleInter()
    {
        inter.SetActive(!inter.activeSelf);
    }

    public void ToggleCulture()
    {
        culture.SetActive(!culture.activeSelf);
    }

    public void ToggleSport()
    {
        sport.SetActive(!sport.activeSelf);
    }

    public void ToggleEvents()
    {
        events.SetActive(!events.activeSelf);
    }

    public void ToggleTechnique()
    {
        technique.SetActive(!technique.activeSelf);
    }

    public void ToggleEntraide()
    {
        entraide.SetActive(!entraide.activeSelf);
    }

    public void ToggleBDS()
    {
        bds.SetActive(!bds.activeSelf);
    }
}
