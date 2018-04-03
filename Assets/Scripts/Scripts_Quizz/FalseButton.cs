using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseButton : MonoBehaviour {

    private GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }


    public void HandleClick()
    {
        gameController.AnswerButtonClicked(false);
    }
}
