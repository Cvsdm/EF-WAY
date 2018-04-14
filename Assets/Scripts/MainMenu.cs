using UnityEngine.SceneManagement;
using UnityEngine;


public class MainMenu : MonoBehaviour
{
    public RectTransform menuContainer; //menu that contains all 3 panels

    private Vector3 desiredMenuPosition;

    private void Start()
    {

    }

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
        SceneManager.LoadSceneAsync("Jeu");
    }

    public void LoadInstructions() //hardcode
    {
        SceneManager.LoadSceneAsync("Instructions");
    }

    public void onCreditClick()
    {
        NavigationOnClick(1);
        //Debug.Log("Credit button has been clicked !");
    }

    public void OnParametresClick()
    {
        NavigationOnClick(2);
        //Debug.Log("Parametres button has been clicked !");
    }

    public void ReturnToMenu ()
    {
        NavigationOnClick(0);
        //Debug.Log("Return button has been clicked !");
    }

}

