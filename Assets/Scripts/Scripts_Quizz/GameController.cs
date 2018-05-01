using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using System.Collections;


public class GameController : MonoBehaviour
{
	public Text questionText;
	public Text scoreDisplay;
	public Text timeRemainingDisplay;
    public Text resultsDisplay;

	public GameObject questionDisplay;
	public GameObject roundEndDisplay;
	public Text highScoreDisplay;
    public Button truebutton;
    public Button falsebutton;
    public Text endbutton;

    private int numberofquestions = 5;
    private int threshold = 20;

    private DataController dataController;
	private RoundData currentRoundData;
	private QuestionData[] questionPool;

	private bool isRoundActive = false;
	private float timeRemaining;
	private int playerScore;
	private int questionIndex;
    private int nb_questionsasked;
    private List<int> alreadytook = new List<int>();
    private Sauvegarde save;


    void Start()
	{
        dataController = FindObjectOfType<DataController>();

        save = FindObjectOfType<Sauvegarde>();
        if (save.Get_langue() == 0)
        {
            truebutton.GetComponentInChildren<Text>().text = "Vrai";
            falsebutton.GetComponentInChildren<Text>().text = "Faux";
        }

        currentRoundData = dataController.GetCurrentRoundData();							// Ask the DataController for the data for the current round. At the moment, we only have one round - but we could extend this
		questionPool = currentRoundData.questions;											// Take a copy of the questions so we could shuffle the pool or drop questions from it without affecting the original RoundData object

		timeRemaining = currentRoundData.timeLimitInSeconds;								// Set the time limit for this round based on the RoundData object
		UpdateTimeRemainingDisplay();
		playerScore = 0;
        nb_questionsasked = 1;
        questionIndex = RandomizetheQuestion(alreadytook);

		ShowQuestion();
		isRoundActive = true;
	}

	void Update()
	{
		if (isRoundActive)
		{
			timeRemaining -= Time.deltaTime;												// If the round is active, subtract the time since Update() was last called from timeRemaining
			UpdateTimeRemainingDisplay();

			if (timeRemaining <= 0f)		EndRound();
		}
	}

    void ShowQuestion()
    {
        Color red = new Color(0.92f, 0.10f, 0.14f, 1);
        Color green = new Color(0.0f, 1.0f, 0.0f, 1);

        QuestionData questionData = questionPool[questionIndex];                            // Get the QuestionData for the current question
        questionText.text = questionData.questionText; 

        if (questionPool[questionIndex].isTrue)
        {
            Changecolor(truebutton, green);
            Changecolor(falsebutton, red);
        }
        else
        {
            Changecolor(truebutton, red);
            Changecolor(falsebutton, green);
        }
        
    }

	public void AnswerButtonClicked(bool isCorrect)
	{
        bool res = questionPool[questionIndex].isTrue;

        /*Color red = new Color(0.92f, 0.10f, 0.14f, 1);
        Color green = new Color(0.0f, 1.0f, 0.0f, 1);
        if (res) { Changecolor(truebutton, green); Changecolor(falsebutton, red); }
        else {  Changecolor(truebutton, red); Changecolor(falsebutton, green); }*/

        if (res == isCorrect)
		{
            playerScore += currentRoundData.pointsAddedForCorrectAnswer;		
			scoreDisplay.text = playerScore.ToString();
		}
        StartCoroutine(DisplayQuestions(0));
	}

    IEnumerator DisplayQuestions(float time)
    {
        yield return new WaitForSeconds(time);

        if (nb_questionsasked < numberofquestions)
        {
            nb_questionsasked++;
            questionIndex = RandomizetheQuestion(alreadytook);
            ShowQuestion();
        }
        else EndRound();
    }

	private void UpdateTimeRemainingDisplay()
	{
		timeRemainingDisplay.text = Mathf.Round(timeRemaining).ToString();
	}

	public void EndRound()
	{
		isRoundActive = false;
        dataController.SubmitNewPlayerScore(playerScore);
        highScoreDisplay.text = dataController.GetHighestPlayerScore().ToString();
		questionDisplay.SetActive(false);
		roundEndDisplay.SetActive(true);
        ShowResults();
	}

	public void ReturnToMenu()
	{
		
        if (playerScore >= threshold)
        {
            Destroy(GameObject.Find("DataController"));
            alreadytook.Clear();
            //SceneManager.LoadScene("Jeu");
            SceneManager.UnloadSceneAsync("Menu_quizz");
            SceneManager.UnloadSceneAsync("Quizz");
            StartCoroutine(save.Load_scenes()); //lancer les dés 
        }
        else
        {
            SceneManager.UnloadSceneAsync("Quizz");
        }
    }

    void Changecolor(Button button, Color newColor)
    {
        ColorBlock color = button.colors;
        color.pressedColor = newColor;
        //color.normalColor = newColor;
        button.colors = color;
    }
    
    private int RandomizetheQuestion (List<int> alreadytook)
    {
        int rnd, flag, i, max;

        max = questionPool.Length;
        do
        {
            flag = 0;
            rnd = Random.Range(0,max);
            for (i = 0; i < alreadytook.Count; i++)
            {
                if (alreadytook[i] == rnd)  flag = 1;
            }
        } while (flag != 0);

        alreadytook.Add(rnd);

        return rnd;
    }

    private void ShowResults()
    {
        if (playerScore >= threshold)
        {
            resultsDisplay.text = "Félicitations, tu as réussis l'examen !";
            endbutton.text = "Continuer";
        }
        else
        {
            resultsDisplay.text = "Oh non ! Ton score est trop bas pour continuer. Retente ta chance !";
            endbutton.text = "Aller au début";
        }
    }

    public void HandleClickTrue()
    {
        /*Color red = new Color(0.92f, 0.10f, 0.14f, 1);
        Color green = new Color(0.0f, 1.0f, 0.0f, 1);

        if (questionPool[questionIndex].isTrue)
            Changecolor(truebutton, green);
        else
            Changecolor(truebutton, red);*/
        AnswerButtonClicked(true);
    }

    public void HandleClickFalse()
    {
       /* Color red = new Color(0.92f, 0.10f, 0.14f, 1);
        Color green = new Color(0.0f, 1.0f, 0.0f, 1);
        if (questionPool[questionIndex].isTrue)
            Changecolor(falsebutton, red);
        else
            Changecolor(falsebutton, green);*/
        AnswerButtonClicked(false);
    }
}