using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour {

    public Canvas question_mark;
    private Sauvegarde save;

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
        StartCoroutine(save.Load_scenes(0f));
    }



}
