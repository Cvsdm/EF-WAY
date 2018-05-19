using UnityEngine.SceneManagement;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    public RectTransform menuContainer; //menu that contains all 3 panels
    public GameObject panel_music;

    private Vector3 desiredMenuPosition;

    private void Update()
    {
        //Menu navigation
        menuContainer.anchoredPosition3D = Vector3.Lerp(menuContainer.anchoredPosition3D, desiredMenuPosition, 0.08f);
    }

    private void NavigationOnClick (int MenuIndex) 
    {
        switch (MenuIndex)
        {
            // 0 and default = go to main menu
            default:
            case 0:
                desiredMenuPosition = Vector3.zero;
                break;
            // 1 = go to credits
            case 1:
                desiredMenuPosition = Vector3.right * 1280;
                break;
            // 2 = go to parameters
            case 2:
                desiredMenuPosition = Vector3.left * 1280;
                break;

        }
    }

    //button's functions
    public void LoadJeu () //hardcode
    {
        SceneManager.LoadSceneAsync("Sauvegarde");
    }

    public void LoadInstructions() //hardcode
    {
        SceneManager.LoadSceneAsync("Instructions");
    }

    public void OnCreditClick()
    {
        NavigationOnClick(1);
        //Debug.Log("Credit button has been clicked !");
    }

    public void OnExit()
    {
        Application.Quit();
    }

    public void OnEnSavoirPLusClick()
    {
        NavigationOnClick(2);
        //Debug.Log("Parametres button has been clicked !");
    }

    public void OnEfreiSiteClick()
    {
        Application.OpenURL("http://www.efrei.fr/");
    }

    public void OnFacebookClick()
    {
        Application.OpenURL("https://www.facebook.com/Efrei/?ref=hl");
    }

    public void OnYTClick()
    {
        Application.OpenURL("https://www.youtube.com/efrei");
    }

    public void OnContactClick()
    {
        Application.OpenURL("http://www.efrei.fr/contacts/");
    }
    


    public void ReturnToMenu ()
    {
        NavigationOnClick(0);
    }

    public void Credit_music()
    {
        Debug.Log("coucou");
        panel_music.gameObject.SetActive(true);
    }

    public void Credit_music_off()
    {
        panel_music.gameObject.SetActive(false);
    }

}

