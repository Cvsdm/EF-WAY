using UnityEngine;
using UnityEngine.UI;

public class Cases : MonoBehaviour {

    private Sauvegarde save;

    public Text text;
    public Button button;

	// Use this for initialization
	void Start () {
        save = FindObjectOfType<Sauvegarde>();	
	}
	
	public void Case_action ()
    {
        Debug.Log("Je suis ds le bon script");

        switch(save.Get_counter()) // switch le numéro de la case :) 
        {
            case 1:
                break;
            case 2:
                break;
        }
    }
}
