using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Canvas question_mark;
    public GameObject lex;
    private Sauvegarde save;
    public Text btn_throw, btn_continue;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
    }

    public void Toggle_canvas()
    {
        if (!question_mark.gameObject.activeSelf)
            question_mark.gameObject.SetActive(true);
        else
            question_mark.gameObject.SetActive(false);
    }

    public void Throw_Dice()
    {
        GameObject.Find("Dés").SetActive(false);
        StartCoroutine(save.Load_scenes(0.8f));
    }

    public void Modify_dice()
    {
        btn_throw.text = "Throw dices";
        btn_continue.text = "Continue";
    }

    public void On_Lexique()
    {
        question_mark.gameObject.SetActive(false);
        lex.gameObject.SetActive(true);
    }

    public void Off_Lexique()
    {
        lex.gameObject.SetActive(false);
    }


}
