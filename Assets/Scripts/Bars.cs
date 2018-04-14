using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
    public float CurrentAssos { get; set; }
    private float MaxAssos { get; set; }

    public float CurrentEtude { get; set; }
    private float MaxEtude { get; set; }

    public float CurrentSocial { get; set; }
    private float MaxSocial { get; set; }

    private Slider assos;
    private Slider etude;
    private Slider social;

    public Text textAssos;
    public Text textEtude;
    public Text textSocial;

    float temp;

    void Start()
    {
        MaxEtude = 100f;
        CurrentEtude = 0f; //sauvegarde current
        etude = GameObject.Find("Etude").GetComponent<Slider>();
        textEtude = GameObject.Find("TextEtude").GetComponent<Text>();
        UpdateEtude();

        MaxAssos = 100f;
        CurrentAssos = 0f; //sauvegarde current
        assos = GameObject.Find("Assos").GetComponent<Slider>();
        textAssos = GameObject.Find("TextAssos").GetComponent<Text>();
        UpdateAssos();


        MaxSocial = 100f;
        CurrentSocial = 0f; // sauvegarde current
        social = GameObject.Find("Sociability").GetComponent<Slider>();
        textSocial = GameObject.Find("TextSocial").GetComponent<Text>();
        UpdateSocial();
    }

    void UpdateAssos()
    {
        assos.value = CalculateAssos();
        float temp = CalculateAssos() * 100;
        textAssos.text = temp.ToString();
    }

    public void DealAssosMinus(float minuspoint)
    {
        CurrentAssos -= minuspoint;
        if (CurrentAssos < 0)
            CurrentAssos = 0;
        UpdateAssos();
    }

    public void DealAssosPlus(float pluspoint)
    {
        CurrentAssos += pluspoint;
        if (CurrentAssos > 100)
            CurrentAssos = 100;
        UpdateAssos();
    }

    float CalculateAssos()
    {
        return CurrentAssos / MaxAssos; //Percentage
    }




    void UpdateEtude()
    {
        etude.value = CalculateEtude();
        float temp = CalculateEtude() * 100;
        textEtude.text = temp.ToString();
    }

    public void DealEtudeMinus(float minuspoint)
    {
        CurrentEtude -= minuspoint;
        if (CurrentEtude < 0)
            CurrentEtude = 0;
        UpdateEtude();
    }

    public void DealEtudePlus(float pluspoint)
    {
        CurrentEtude += pluspoint;
        if (CurrentEtude > 100)
            CurrentEtude = 100;
        UpdateEtude();
    }

    float CalculateEtude()
    {
        return CurrentEtude / MaxEtude; //Percentage
    }



    void UpdateSocial()
    {
        social.value = CalculateSocial();
        float temp = CalculateSocial() * 100;
        textSocial.text = temp.ToString();
    }

    public void DealSocialMinus(float minuspoint)
    {
        CurrentSocial -= minuspoint;
        if (CurrentSocial < 0)
            CurrentSocial = 0;
        UpdateSocial();
    }

    public void DealSocialPlus(float pluspoint)
    {
        CurrentSocial += pluspoint;
        if (CurrentSocial > 100)
            CurrentSocial = 100;
        UpdateSocial();
    }

    float CalculateSocial()
    {
        //Per centage
        return CurrentSocial / MaxSocial;
    }
}
