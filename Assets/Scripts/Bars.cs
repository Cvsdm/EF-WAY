using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
    public float CurrentAssos { get; set; }
    public float MaxAssos { get; set; }

    public float CurrentEtude { get; set; }
    public float MaxEtude { get; set; }

    public float CurrentSocial { get; set; }
    public float MaxSocial { get; set; }

    public Slider assos;
    public Slider etude;
    public Slider social;

    public Text textAssos;
    public Text textEtude;
    public Text textSocial;

    float temp;

    void Start()
    {
        MaxEtude = 100f;
        CurrentEtude = 0f;
        etude = GameObject.Find("Etude").GetComponent<Slider>();
        etude.value = CalculateEtude();
        textEtude = GameObject.Find("TextEtude").GetComponent<Text>();
        temp = CalculateEtude() * 100;
        textEtude.text = temp.ToString();

        MaxAssos = 100f;
        CurrentAssos = 0f;
        assos = GameObject.Find("Assos").GetComponent<Slider>();
        assos.value = CalculateAssos();
        textAssos = GameObject.Find("TextAssos").GetComponent<Text>();
        temp = CalculateAssos() * 100;
        textAssos.text = temp.ToString();


        MaxSocial = 100f;
        CurrentSocial = 0f;
        social = GameObject.Find("Sociability").GetComponent<Slider>();
        social.value = CalculateSocial();
        textSocial = GameObject.Find("TextSocial").GetComponent<Text>();
        temp = CalculateSocial() * 100;
        textSocial.text = temp.ToString();
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
        //Per centage
        return CurrentAssos / MaxAssos;
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
        //Per centage
        return CurrentEtude / MaxEtude;
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
