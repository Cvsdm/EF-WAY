using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class InstructionScript : MonoBehaviour
{

    public RectTransform InstructionContainer; //menu that contains all panels

    private Vector3 desiredInstructionPosition;

    public GameObject caseExplanation1;
    public GameObject caseExplanation2;
    public GameObject caseExplanation3;

    private void Start()
    {
        caseExplanation1.SetActive(false); //to hide the menu at the begining
        caseExplanation2.SetActive(false); //to hide the menu at the begining
        caseExplanation3.SetActive(false); //to hide the menu at the begining
    }

    public void ToggleCaseExplanation1()    //toggle on or off the pause menu
    {
        caseExplanation1.SetActive(!caseExplanation1.activeSelf); //return true if the button is on, else off so we turn it off if it's on
    }

    public void ToggleCaseExplanation2()    //toggle on or off the pause menu
    {
        caseExplanation2.SetActive(!caseExplanation2.activeSelf); //return true if the button is on, else off so we turn it off if it's on
    }

    public void ToggleCaseExplanation3()    //toggle on or off the pause menu
    {
        caseExplanation3.SetActive(!caseExplanation3.activeSelf); //return true if the button is on, else off so we turn it off if it's on
    }

    private void Update()
    {
        //Instruction navigation
        InstructionContainer.anchoredPosition3D = Vector3.Lerp(InstructionContainer.anchoredPosition3D, desiredInstructionPosition, 0.2f);
    }

    public void LoadMainMenu() //hardcode
    {
        SceneManager.LoadSceneAsync("MainMenu");
        //Debug.Log("X button has been clicked !");
    }

    private void NavigateOnClick(int InstructionIndex)
    {
        Vector3 correction_x;
        switch (InstructionIndex)
        {
            // 0 and default = go to main menu
            default:
            case 0: 
                LoadMainMenu();
                break;
            // 1 = go to the left
            case 1:
                //Debug.Log("pos :" + InstructionContainer.anchoredPosition3D.x);

                correction_x = InstructionContainer.anchoredPosition3D;
                correction_x.x = (int)InstructionContainer.anchoredPosition3D.x;
                while (correction_x.x % 1280 != 0)
                    correction_x.x --;
                //     correction_x.x = correction_x.x + correction_x.x - 1280;

                //Debug.Log("counter :" + correction_x.x);
                desiredInstructionPosition = correction_x + Vector3.right * 1280 ;
                break;
            // 2 = go to the right
            case 2:
                //Debug.Log("pos :" + InstructionContainer.anchoredPosition3D.x);
                correction_x = InstructionContainer.anchoredPosition3D;
                correction_x.x = (int)InstructionContainer.anchoredPosition3D.x;
                while (correction_x.x % 1280 != 0)
                    correction_x.x--;
                //    correction_x.x = correction_x.x + correction_x.x - 1280;

                //Debug.Log("counter :" + correction_x.x);
                desiredInstructionPosition = correction_x + Vector3.left * 1280;
                //desiredInstructionPosition = InstructionContainer.anchoredPosition3D + Vector3.left * 1280;
                break;

        }
    }

    //button's functions
    public void toMenuClick()
    {
        NavigateOnClick(0);
        //Debug.Log("X button has been clicked !");
    }

    public void toLeftClick()
    {
        NavigateOnClick(1);
        //Debug.Log("<< button has been clicked !");
    }

    public void toRightClick()
    {
        NavigateOnClick(2);
        //Debug.Log(">> button has been clicked !");
    }
}
