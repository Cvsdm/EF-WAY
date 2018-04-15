using UnityEngine;
using UnityEngine.UI;

public class Bars : MonoBehaviour
{
    private float CurrentAssos { get; set; }
    private float MaxAssos { get; set; }

    private float CurrentEtude { get; set; }
    private float MaxEtude { get; set; }

    private float CurrentSocial { get; set; }
    private float MaxSocial { get; set; }

    private Slider assos;
    private Slider etude;
    private Slider social;

    private Text textAssos;
    private Text textEtude;
    private Text textSocial;

    private Sauvegarde save;

    float temp;

    void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        MaxEtude = 100f;
        CurrentEtude = save.Get_etude();
        etude = GameObject.Find("Etude").GetComponent<Slider>();
        textEtude = GameObject.Find("TextEtude").GetComponent<Text>();
        UpdateEtude();

        MaxAssos = 100f;
        CurrentAssos = save.Get_assos();
        assos = GameObject.Find("Assos").GetComponent<Slider>();
        textAssos = GameObject.Find("TextAssos").GetComponent<Text>();
        UpdateAssos();


        MaxSocial = 100f;
        CurrentSocial = save.Get_sociabilite();
        social = GameObject.Find("Sociability").GetComponent<Slider>();
        textSocial = GameObject.Find("TextSocial").GetComponent<Text>();
        UpdateSocial();
    }

    void UpdateAssos()
    {
        save.Set_assos(CurrentAssos);
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
        save.Set_etude(CurrentEtude);
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
        save.Set_sociabilite(CurrentSocial);
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
