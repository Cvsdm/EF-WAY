using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
    private float CurrentAssos;
    private float MaxAssos;

    private float CurrentEtude;
    private float MaxEtude;

    private float CurrentSocial;
    private float MaxSocial;

    private Slider assos;
    private Slider etude;
    private Slider social;

    private Text textAssos;
    private Text textEtude;
    private Text textSocial;

    private Sauvegarde save;


    void Start()
    {
        save = FindObjectOfType<Sauvegarde>();

        MaxEtude = 200f;
        CurrentEtude = save.Get_etude();
        etude = GameObject.Find("Etude").GetComponent<Slider>();
        textEtude = GameObject.Find("TextEtude").GetComponent<Text>();
        UpdateEtude();

        MaxAssos = 200f;
        CurrentAssos = save.Get_assos();
        assos = GameObject.Find("Assos").GetComponent<Slider>();
        textAssos = GameObject.Find("TextAssos").GetComponent<Text>();
        UpdateAssos();


        MaxSocial = 200f;
        CurrentSocial = save.Get_sociabilite();
        social = GameObject.Find("Sociability").GetComponent<Slider>();
        textSocial = GameObject.Find("TextSocial").GetComponent<Text>();
        UpdateSocial();
    }

    void UpdateAssos()
    {
        save.Set_assos(CurrentAssos);
        assos.value = CalculateAssos();
        //float temp = CalculateAssos() * 100;
        textAssos.text = CurrentAssos.ToString();
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
        if (CurrentAssos > MaxAssos)
            CurrentAssos = MaxAssos;
        UpdateAssos();
    }

    float CalculateAssos()
    {
        return CurrentAssos / MaxAssos; //Percentage
    }

    void UpdateEtude()
    {
        save.Set_etude(CurrentEtude);
        etude.value = CalculateEtude();
        //float temp = CalculateEtude() * 100;
        textEtude.text = CurrentEtude.ToString();
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
        if (CurrentEtude > MaxEtude)
            CurrentEtude = MaxEtude;
        UpdateEtude();
    }

    float CalculateEtude()
    {
        return CurrentEtude / MaxEtude; //Percentage
    }

    void UpdateSocial()
    {
        save.Set_sociabilite(CurrentSocial);
        social.value = CalculateSocial();
        //float temp = CalculateSocial() * 100;
        textSocial.text = CurrentSocial.ToString();
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
        if (CurrentSocial > MaxSocial)
            CurrentSocial = MaxSocial;
        UpdateSocial();
    }

    float CalculateSocial()
    {
        return CurrentSocial / MaxSocial;
    }
}
