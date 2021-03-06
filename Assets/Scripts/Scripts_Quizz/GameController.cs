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
    public GameObject SectionDisplay;
    public Text EndScoreDisplay;
    public Button truebutton;
    public Button falsebutton;
    public Text endbutton;

    private int numberofquestions = 5;
    private int threshold = 60;

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
        EndScoreDisplay.text = playerScore.ToString();
		questionDisplay.SetActive(false);
		roundEndDisplay.SetActive(true);
        ShowResults();
	}

	public void ReturnToMenu()
	{
		
        if (playerScore >= threshold || dataController.Get_attempt() == 3)
        {
            if (dataController.Get_attempt() != 3)
                FindObjectOfType<Bars>().DealEtudePlus(playerScore / 4); // ?? A VOIR ^^ 
            Destroy(GameObject.Find("DataController"));
            alreadytook.Clear();
            SceneManager.UnloadSceneAsync("Menu_quizz");
            if (save.Get_counter() != 4)
                save.Disp_after_Stop("Quizz");
            else
                SectionDisplay.gameObject.SetActive(true);
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
            if (save.Get_langue() == 0)
            {
                resultsDisplay.text = "Félicitations, tu as réussis l'examen !";
                endbutton.text = "Continuer";
            }
            else
            {
                resultsDisplay.text = "Congratulations, you've suceeded the exam !";
                endbutton.text = "Continue";
            }
        }
        else if (dataController.Get_attempt() == 2)
        {
            if (save.Get_langue() == 0)
            {
                resultsDisplay.text = "Tu as raté ton examen pour la seconde fois ! Tu n'auras aucun point.";
                endbutton.text = "Continuer";
            }
            else
            {
                resultsDisplay.text = "You've failed the exam for the second time ! You'll not earn any point.";
                endbutton.text = "Continue";
            }
            dataController.Set_attempt(dataController.Get_attempt() + 1);
        }
        else
        {
            dataController.Set_attempt(dataController.Get_attempt() + 1);
            if (save.Get_langue() == 0)
            {

                if (playerScore < 30)
                {
                    resultsDisplay.text = "Oh non ! Ton score est beaucoup trop bas.\n - 10 points Etudes ! \nRetente ta chance !";
                    FindObjectOfType<Bars>().DealEtudeMinus(10f);
                }

                else
                    resultsDisplay.text = "Oh non ! Ton score est trop bas pour continuer. \nRetente ta chance !";
                endbutton.text = "Aller au début";

            }
            else
            {
                if (playerScore < 30)
                {
                    resultsDisplay.text = "No.. Your score is way too low to continue.\n - 10 points Study !\nTry again !";
                    FindObjectOfType<Bars>().DealEtudeMinus(10f);
                }
                else 
                    resultsDisplay.text = "No.. Your score is too low to continue. Try again !";
                endbutton.text = "Restart the quizz";
            }
            Debug.Log("attempt : " + dataController.Get_attempt());
        }
    }

    public void HandleClickTrue() { AnswerButtonClicked(true);  }

    public void HandleClickFalse() { AnswerButtonClicked(false); }

    public void SectionChoice ()
    {
        SceneManager.LoadScene("Menu Sections", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Quizz");
    }
}