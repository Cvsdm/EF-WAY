using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.IO;                                                       
public class DataController : MonoBehaviour
{
    private RoundData allRoundData;
    private PlayerProgress playerProgress;
    private Database database;

    void Start()
    {
        database = FindObjectOfType<Database>();
        DontDestroyOnLoad(gameObject);

        LoadPlayerProgress();
        LoadData();

        SceneManager.LoadScene("MenuScreen");
    }

    public RoundData GetCurrentRoundData()
    {
        return allRoundData;
    }

    public void SubmitNewPlayerScore(int newScore)
    {
        if (newScore > playerProgress.highestScore)
        {
            playerProgress.highestScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighestPlayerScore()
    {
        return playerProgress.highestScore;
    }

    private void LoadPlayerProgress()
    {
        playerProgress = new PlayerProgress();

        if (PlayerPrefs.HasKey("highestScore"))
        {
            playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
        }
    }

    private void LoadData()
    {
        allRoundData = new RoundData();
        allRoundData.timeLimitInSeconds = 30;
        allRoundData.pointsAddedForCorrectAnswer = 10;
        //allRoundData.questions = new QuestionData[14];
        allRoundData.questions = database.allquestions;
        //Debug.Log("questions[0]" + allRoundData.questions[0].questionText + "answer " + allRoundData.questions[0].isTrue);

        /*allRoundData = new RoundData
        {
            timeLimitInSeconds = 30,
            pointsAddedForCorrectAnswer = 10,
            //allRoundData.questions = new QuestionData[14],
            questions = database.allquestions,
        };*/


    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    }
}