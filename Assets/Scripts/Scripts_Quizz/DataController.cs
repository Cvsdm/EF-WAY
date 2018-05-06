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
        quizz_data = FindObjectOfType<Quizz_data>();
        fileName = quizz_data.filename;

        database = FindObjectOfType<Database>();
        database.Create_Database(fileName);
        DontDestroyOnLoad(gameObject);

        LoadData();

        SceneManager.LoadScene("Menu_quizz", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Persistent_quizz");
    }

    public RoundData GetCurrentRoundData()
    {
        return allRoundData;
    }

    private void LoadData()
    {
        allRoundData = new RoundData
        {
            timeLimitInSeconds = 50,
            pointsAddedForCorrectAnswer = 20,
            questions = database.allquestions
        };
    }
}