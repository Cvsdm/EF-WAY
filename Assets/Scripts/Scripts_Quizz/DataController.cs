using UnityEngine;
using UnityEngine.SceneManagement;


public class DataController : MonoBehaviour
{
    private RoundData allRoundData;
    private Database database;
    private Quizz_data quizz_data;
    private string fileName;
    private int attempt = 1; 

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
            timeLimitInSeconds = 60,
            pointsAddedForCorrectAnswer = 20,
            questions = database.allquestions
        };
    }

    public int Get_attempt() { return attempt; }
    public void Set_attempt(int att) { attempt = att; }

}