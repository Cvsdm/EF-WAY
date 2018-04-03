using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueButton : MonoBehaviour {

    private GameController gameController;

    void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    public void HandleClick()
    {
        gameController.AnswerButtonClicked(true);
    }
}
