using UnityEngine;
using UnityEngine.SceneManagement;


public class DataController : MonoBehaviour
{
    private RoundData allRoundData;
    private PlayerProgress playerProgress;
    private Database database;
    private Quizz_data quizz_data;
    private string fileName;

    void Start()
    {
        /*ADD SOMETHING TO KEEP TRACK OF THE CASE*/
        quizz_data = FindObjectOfType<Quizz_data>();
        fileName = quizz_data.filename;  //replace 0 by the corresponding number

        database = FindObjectOfType<Database>();
        database.Create_Database(fileName);
        DontDestroyOnLoad(gameObject);

        LoadPlayerProgress();
        LoadData();

        SceneManager.LoadScene("Menu_quizz");
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
        allRoundData = new RoundData
        {
            timeLimitInSeconds = 30,
            pointsAddedForCorrectAnswer = 10,
            questions = database.allquestions
        };
    }

    private void SavePlayerProgress()
    {
        PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    }
}