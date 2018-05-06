using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Rotation2 : MonoBehaviour
{
    private int Dice1;
    private int Dice2;

    private int TotalValue;
    private float smooth = 70.0F;

    private bool isTurning;

    Quaternion target;
    Quaternion target2;

    InputField x;

    public GameObject Cube2;
    public GameObject Cube1;
    public Text Result;

    private Sauvegarde save;

    void Start()
    {
        Result.gameObject.SetActive(false);
        save = FindObjectOfType<Sauvegarde>();

        isTurning = true;
    }

    public void Update()
    {

        if (isTurning == true)
        {
            Cube1.transform.rotation = Random.rotationUniform;
            Cube2.transform.rotation = Random.rotationUniform;
        }

        else
        {
            Cube1.GetComponent<Rigidbody>().freezeRotation = true;
            Cube2.GetComponent<Rigidbody>().freezeRotation = true;
            Cube2.GetComponent<Rigidbody>().useGravity = true;
            Cube1.GetComponent<Rigidbody>().useGravity = true;

            switch (Dice1)
            {
                case 0:
                    target = Quaternion.Euler(0, -30, 180);
                    break;
                case 1:
                    target = Quaternion.Euler(-180, 10, 189);
                    break;
                case 2:
                    target = Quaternion.Euler(-90, 0, 166);
                    break;
                case 3:
                    target = Quaternion.Euler(0, 0, 90);
                    break;
                case 4:
                    target = Quaternion.Euler(-180, 25, 90);
                    break;
                case 5:
                    target = Quaternion.Euler(90, 0, 50);
                    break;
            }

            Cube1.transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);

            switch (Dice2)
            {
                case 0:
                    target2 = Quaternion.Euler(0, -30, 180);
                    break;
                case 1:
                    target2 = Quaternion.Euler(-180, 10, 189);
                    break;
                case 2:
                    target2 = Quaternion.Euler(-90, 0, 166);
                    break;
                case 3:
                    target2 = Quaternion.Euler(0, 0, 90);
                    break;
                case 4:
                    target2 = Quaternion.Euler(-180, 25, 90);
                    break;
                case 5:
                    target2 = Quaternion.Euler(90, 0, 50);
                    break;
            }

            Cube2.transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth);

            if (GetRotation() > 0)
            {
                Result.gameObject.SetActive(true);
                Result.text = TotalValue.ToString();
                enabled = false;
            }
        }
    }


    public void Drop2()         /// Stop rotating & Drop
    {
        StartCoroutine(BreakDisplayResult());
    }

    public IEnumerator BreakDisplayResult()
    {
        isTurning = false;
        EnableButton();
        yield return new WaitForSecondsRealtime(5);
        SceneManager.UnloadSceneAsync("lancé de dés");
        save.Disp_game();
    }

    public void Buttontouch()
    {
        save = FindObjectOfType<Sauvegarde>();
        SceneManager.UnloadSceneAsync("lancé de dés");
        save.Disp_game();
    }

    void EnableButton()
    {
        GameObject.Find("Drop").SetActive(false);

       
        Dice1 = Random.Range(0, 5);
        Dice2 = Random.Range(0,5);
        TotalValue = Dice1 + Dice2;

        //save.Set_nextmove(10); //pour tester
        save.Set_nextmove(TotalValue);
    }

    int GetRotation()
    {
        int a = GetRotation1();
        int b = GetRotation2();

        return a + b;
    }

    int GetRotation1()
    {
        Vector3 Rotation1 = Cube1.transform.eulerAngles;

        if ((Cube1.transform.eulerAngles.x <= 1 && Cube1.transform.eulerAngles.x >= -1) && (Cube1.transform.eulerAngles.z >= 179 && Cube1.transform.eulerAngles.z <= 181))
            return 0;
        else if ((Cube1.transform.eulerAngles.x <= 1 && Cube1.transform.eulerAngles.x >= -1) && (Cube1.transform.eulerAngles.y <= 1 && Cube1.transform.eulerAngles.y >= -1) && (Cube1.transform.eulerAngles.z <= 91 && Cube1.transform.eulerAngles.z >= 89))
            return 3;
        else if ((Cube1.transform.eulerAngles.x <= 1 && Cube1.transform.eulerAngles.x >= -1) && (Cube1.transform.eulerAngles.z >= 269 && Cube1.transform.eulerAngles.z <= 271))
            return 4;
        else if ((Cube1.transform.eulerAngles.x <= 1 && Cube1.transform.eulerAngles.x >= -1))
            return 1;
        else if ((Cube1.transform.eulerAngles.x >= 269 && Cube1.transform.eulerAngles.x <= 271))
            return 2;
        else if ((Cube1.transform.eulerAngles.x >= 89 && Cube1.transform.eulerAngles.x <= 91))
            return 5;
        return -2000;
    }

    int GetRotation2()
    {
        Vector3 Rotation2 = Cube2.transform.eulerAngles;

        if ((Cube2.transform.eulerAngles.x <= 1 && Cube2.transform.eulerAngles.x >= -1) && (Cube2.transform.eulerAngles.z >= 179 && Cube2.transform.eulerAngles.z <= 181))
            return 0;
        else if ((Cube2.transform.eulerAngles.x <= 1 && Cube2.transform.eulerAngles.x >= -1) && (Cube2.transform.eulerAngles.y <= 1 && Cube2.transform.eulerAngles.y >= -1) && (Cube2.transform.eulerAngles.z <= 91 && Cube2.transform.eulerAngles.z >= 89))
            return 3;
        else if ((Cube2.transform.eulerAngles.x <= 1 && Cube2.transform.eulerAngles.x >= -1) && (Cube2.transform.eulerAngles.z >= 269 && Cube2.transform.eulerAngles.z <= 271))
            return 4;
        else if ((Cube2.transform.eulerAngles.x <= 1 && Cube2.transform.eulerAngles.x >= -1))
            return 1;
        else if ((Cube2.transform.eulerAngles.x >= 269 && Cube2.transform.eulerAngles.x <= 271))
            return 2;
        else if ((Cube2.transform.eulerAngles.x >= 89 && Cube2.transform.eulerAngles.x <= 91))
            return 5;
        return -2000;
    }

}
