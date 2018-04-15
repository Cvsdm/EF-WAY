using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Rotation2 : MonoBehaviour
{
    struct Resultats
    {
        public int D1;
        public int D2;
    }

    public int DiceValues;
    public int DiceValues2;

    Resultats R;

    public float smooth2 = 10.0F;

    bool hello2 = true;
    bool GoAhead1 = false;

    Quaternion target2;

    // public Text countText;
    // public Text countText2;


    public float smooth = 10.0F;

    bool hello = true;

    Quaternion target;

    bool dice2;

    int alreadyDropped = 0;



    public Text countText3;
    public InputField x;
    string res1;
    int res3;

    public int TotalValue;

    public GameObject Cube1;
    public GameObject Cube;

    void Start()
    {
        GameObject.Find("Go").GetComponent<Button>().enabled = false;
        GameObject.Find("Go").transform.localScale = new Vector3(0, 0, 0);
        GameObject.Find("Result (2)").transform.localScale = new Vector3(0, 0, 0);
    }

    public void Update()
    {
        if (dice2 == true)
        {
            if (hello2 == true)
            {
                transform.rotation = Random.rotationUniform;
            }

            else
            {

                GameObject.Find("Cube1").GetComponent<Rigidbody>().freezeRotation = true;
                GameObject.Find("Cube1").GetComponent<Rigidbody>().useGravity = true;

                switch (DiceValues2)
                {
                    case 0:
                        target2 = Quaternion.Euler(0, -30, 180);
                        GameObject.Find("Cube1").transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth2);
                        break;
                    case 1:
                        target2 = Quaternion.Euler(-180, 10, 189);
                        GameObject.Find("Cube1").transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth2);
                        break;
                    case 2:
                        target2 = Quaternion.Euler(-90, 0, 166);
                        GameObject.Find("Cube1").transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth2);
                        break;
                    case 3:
                        target2 = Quaternion.Euler(0, 0, 90);
                        GameObject.Find("Cube1").transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth2);
                        break;
                    case 4:
                        target2 = Quaternion.Euler(-180, 25, 90);
                        GameObject.Find("Cube1").transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth2);
                        break;
                    case 5:
                        target2 = Quaternion.Euler(90, 0, 50);
                        GameObject.Find("Cube1").transform.rotation = Quaternion.Slerp(transform.rotation, target2, Time.deltaTime * smooth2);
                        break;
                }
                //countText2.text = DiceValues2.ToString();
            }

        }
        else
        {
            if (hello == true)
            {
                transform.rotation = Random.rotationUniform;
            }
            else
            {
                GameObject.Find("Cube").GetComponent<Rigidbody>().freezeRotation = true;
                GameObject.Find("Cube").GetComponent<Rigidbody>().useGravity = true;
                switch (DiceValues)
                {
                    case 0:
                        target = Quaternion.Euler(0, -30, 180);
                        GameObject.Find("Cube").transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                        break;
                    case 1:
                        target = Quaternion.Euler(-180, 10, 189);
                        GameObject.Find("Cube").transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                        break;
                    case 2:
                        target = Quaternion.Euler(-90, 0, 166);
                        GameObject.Find("Cube").transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                        break;
                    case 3:
                        target = Quaternion.Euler(0, 0, 90);
                        GameObject.Find("Cube").transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                        break;
                    case 4:
                        target = Quaternion.Euler(-180, 25, 90);
                        GameObject.Find("Cube").transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                        break;
                    case 5:
                        target = Quaternion.Euler(90, 0, 50);
                        GameObject.Find("Cube").transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
                        break;
                }
                //countText.text = DiceValues.ToString();
            }
            /*  if (alreadyDropped == 1)
              {
                  StoreValues(DiceValues);
                  alreadyDropped++;
              }*/

            int pouet = GetRotation1();

            if (pouet != -2000)
                GoAhead1 = true;

            if (GoAhead1 == true)
            {
                GetRotation();
                if (TotalValue >= 0 && TotalValue <= 10)
                    GameObject.Find("Result (2)").transform.localScale = new Vector3(1, 1, 1);

            }
        }
        //  Debug.Log("D1 :" + R.D1 + " | D2 :" + R.D2);
    }


    public void Drop2()
    {
        /// Stop rotating
        /// Drop
        if (alreadyDropped < 1)
        {
            DiceValues2 = Random.Range(0, 5);
            hello2 = false;
            dice2 = true;
            alreadyDropped += 1;
            EnableButton();
            //ValueD2(DiceValues2, 1);
            //  DiceValues2 = 4;
            GetRotation();
        }
    }

    public void Drop()
    {
        /// Stop rotating
        /// Drop
        if (alreadyDropped < 1)
        {
            alreadyDropped += 1;
            hello = false;
            dice2 = false;
            DiceValues = Random.Range(0, 5); 
        }
    }
    
    void EnableButton()
    {
        GameObject.Find("Go").GetComponent<Button>().enabled = true;
        GameObject.Find("Go").transform.localScale = new Vector3(1, 1, 1);

        GameObject.Find("Drop").GetComponent<Button>().enabled = false;
        GameObject.Find("Drop").transform.localScale = new Vector3(0, 0, 0);

        TotalValue = D1 + D2;
        countText3.text = "T=" + TotalValue;
    }


    static int D2;
    static int D1;

    int ValueD2(int val, int a)
    {
        if (a == 1)
        {
            D2 = val;
            return val;
        }
        else
        {
            return -100;
        }
    }

    int ValueD1(int val, int a)
    {
        if (a == 1)
        {
            D1 = val;
            return val;
        }
        return -100;
    }


    void GetRotation()
    {
        int a = GetRotation1();
        int b = GetRotation2();
        TotalValue = a + b;
        
        countText3.text = TotalValue.ToString();
    }

    int GetRotation1()
    {
        Vector3 Rotation1 = GameObject.Find("Cube").transform.eulerAngles;

        if ((GameObject.Find("Cube").transform.eulerAngles.x <= 1 && GameObject.Find("Cube").transform.eulerAngles.x >= -1) && (GameObject.Find("Cube").transform.eulerAngles.z >= 179 && GameObject.Find("Cube").transform.eulerAngles.z <= 181))
            return 0;
        else if ((GameObject.Find("Cube").transform.eulerAngles.x <= 1 && GameObject.Find("Cube").transform.eulerAngles.x >= -1) && (GameObject.Find("Cube").transform.eulerAngles.y <= 1 && GameObject.Find("Cube").transform.eulerAngles.y >= -1) && (GameObject.Find("Cube").transform.eulerAngles.z <= 91 && GameObject.Find("Cube").transform.eulerAngles.z >= 89))
            return 3;
        else if ((GameObject.Find("Cube").transform.eulerAngles.x <= 1 && GameObject.Find("Cube").transform.eulerAngles.x >= -1) && (GameObject.Find("Cube").transform.eulerAngles.z >= 269 && GameObject.Find("Cube").transform.eulerAngles.z <= 271))
            return 4;
        else if ((GameObject.Find("Cube").transform.eulerAngles.x <= 1 && GameObject.Find("Cube").transform.eulerAngles.x >= -1))
            return 1;
        else if ((GameObject.Find("Cube").transform.eulerAngles.x >= 269 && GameObject.Find("Cube").transform.eulerAngles.x <= 271))
            return 2;
        else if ((GameObject.Find("Cube").transform.eulerAngles.x >= 89 && GameObject.Find("Cube").transform.eulerAngles.x <= 91))
            return 5;
        return -2000;
    }

    int GetRotation2()
    {
        Vector3 Rotation2 = GameObject.Find("Cube1").transform.eulerAngles;

        if ((GameObject.Find("Cube1").transform.eulerAngles.x <= 1 && GameObject.Find("Cube1").transform.eulerAngles.x >= -1) && (GameObject.Find("Cube1").transform.eulerAngles.z >= 179 && GameObject.Find("Cube1").transform.eulerAngles.z <= 181))
            return 0;
        else if ((GameObject.Find("Cube1").transform.eulerAngles.x <= 1 && GameObject.Find("Cube1").transform.eulerAngles.x >= -1) && (GameObject.Find("Cube1").transform.eulerAngles.y <= 1 && GameObject.Find("Cube1").transform.eulerAngles.y >= -1) && (GameObject.Find("Cube1").transform.eulerAngles.z <= 91 && GameObject.Find("Cube1").transform.eulerAngles.z >= 89))
            return 3;
        else if ((GameObject.Find("Cube1").transform.eulerAngles.x <= 1 && GameObject.Find("Cube1").transform.eulerAngles.x >= -1) && (GameObject.Find("Cube1").transform.eulerAngles.z >= 269 && GameObject.Find("Cube1").transform.eulerAngles.z <= 271))
            return 4;
        else if ((GameObject.Find("Cube1").transform.eulerAngles.x <= 1 && GameObject.Find("Cube1").transform.eulerAngles.x >= -1))
            return 1;
        else if ((GameObject.Find("Cube1").transform.eulerAngles.x >= 269 && GameObject.Find("Cube1").transform.eulerAngles.x <= 271))
            return 2;
        else if ((GameObject.Find("Cube1").transform.eulerAngles.x >= 89 && GameObject.Find("Cube1").transform.eulerAngles.x <= 91))
            return 5;
        return -2000;
    }
}


