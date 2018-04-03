using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoixMajeures : MonoBehaviour {

    public int ChoixM;
    public Text choice;

	public void Choix_BI()
    {
        ChoixM = 1;
        choice.text = "Choice : BI";
    }
    public void Choix_ISCC()
    {
        ChoixM = 2;
        choice.text = "Choice : ISCC";
    }
    public void Choix_VR()
    {
        ChoixM = 3;
        choice.text = "Choice : VR";
    }
    public void Choix_BD()
    {
        ChoixM = 4;
        choice.text = "Choice : BD" ;
    }
    public void Choix_F()
    {
        ChoixM = 5;
        choice.text = "Choice : F" ;
    }
    public void Choix_Secu()
    {
        ChoixM = 6;
        choice.text = "Choice : S" ;
    }
    public void Choix_IL()
    {
        ChoixM = 7;
        choice.text = "Choice : IL";
    }
    public void Choix_B()
    {
        ChoixM = 8;
        choice.text = "Choice : B" ;
    }
    public void Choix_AE()
    {
        ChoixM = 9;
        choice.text = "Choice : AE";
    }
    public void Choix_DD()
    {
        ChoixM = 10;
        choice.text = "Choice : DD";
    }
    public void Choix_NV()
    {
        ChoixM = 11;
        choice.text = "Choice : NV";
    }
    public void Choix_ENRI()
    {
        ChoixM = 12;
        choice.text = "Choice : ENRI" ;
    }
}
