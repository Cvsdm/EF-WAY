using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Triggered : MonoBehaviour {

    private bool was_triggered;
    public int intersection;
    private Sauvegarde save;
    private Cases cases;

    public GameObject CaseDisplay;
    public Text text;
    public Button button, btn1_dilemme, btn2_dilemme;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        cases = FindObjectOfType<Cases>();
        was_triggered = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        Movement.flag = false;
        if (!was_triggered)
        {
            was_triggered = true;

            if (Movement.advance == 0) //si il n'y a pas de sauvegarde
            {
                if (save.Get_nextmove() != 0)
                {
                    save.Set_counter(save.Get_counter() + 1);
                    save.Set_nextmove(save.Get_nextmove() - 1);
                }

                if (this.name.Length >= 10)
                {
                        Movement.path_counter += 1;

                        if (this.intersection == 1) //Movement.pathname = "J1_" + Movement.path_counter + "_LEFT";
                        {
                            if (this.name.Equals("P6_ENDPATH") && save.Get_counter() == 52)
                                Move_counter();
                            if (save.Get_nextmove() != 0) // si il reste des cases à bouger
                            {
                                //Debug.Log("case n° " + save.Get_counter());
                                if (save.Get_counter() != 46) // si ce n'est pas la case immersion
                                    StartCoroutine(Choice());
                                else
                                {
                                    if (save.Get_imm())
                                        Movement.pathname = "J1_" + Movement.path_counter + "_LEFT";
                                    else
                                    {
                                        Movement.pathname = "J1_" + Movement.path_counter + "_RIGHT";
                                        Move_counter();
                                    }

                                    Movement.Play_iTween(GameObject.Find("Sphere_path"));
                                }
                            }
                            else
                                iTween.Pause();
                        }
                        else
                        {
                            Movement.pathname = "J1_" + Movement.path_counter;

                        if (save.Get_nextmove() != 0)
                            Movement.Play_iTween(GameObject.Find("Sphere_path"));
                        else
                            Movement.flag = true;

                            Move_counter();
                        }
                    }

                if (save.Get_nextmove() == 0 || save.Get_counter() == 100) /// Avance until the dice number
                {
                    iTween.Pause();
                    StartCoroutine(Action_Case(0.8f)); //lancer l'action de la case
                }
                else if (IsStop())
                {
                    iTween.Pause();
                    StartCoroutine(Action_Case(0.8f));
                }
            } 
            else // sauvegarde présente 
            {
                Movement.advance --;
                Movement.j++;
                if (Movement.advance == 0) { iTween.Pause(); Sauvegarde.dices.gameObject.SetActive(true); }

                else
                {
                    if (this.name.Length >= 10) // ex : P1_ENDPATH
                    {
                        Movement.path_counter += 1;
                        if (this.intersection == 1)
                        {
                            if (this.name.Equals("P6_ENDPATH") && Movement.advance == 52)
                                Move_advance();
                            if (Isleft(save.Get_counter()))
                                Movement.pathname = "J1_" + Movement.path_counter + "_LEFT";
                            else
                            {
                                Movement.pathname = "J1_" + Movement.path_counter + "_RIGHT";
                                Move_advance();
                            }
                        }

                        else
                        {
                            Movement.pathname = "J1_" + Movement.path_counter;
                            Move_advance();
                        }

                        Movement.Play_iTween(other.gameObject);
                    }
                }
            }
        }
    }


    public IEnumerator Choice()
    {
        yield return 1;
        iTween.Pause();

        CaseDisplay.SetActive(true);

        button.gameObject.SetActive(false);
        if (save.Get_langue() == 0)
        {
            text.text = "Choisissez votre chemin";
            btn1_dilemme.GetComponentInChildren<Text>().text = "Gauche";
            btn2_dilemme.GetComponentInChildren<Text>().text = "Droite";
        }
        else
        {
            text.text = "Choose your path";
            btn1_dilemme.GetComponentInChildren<Text>().text = "Left";
            btn2_dilemme.GetComponentInChildren<Text>().text = "Right";
        }
        btn1_dilemme.gameObject.SetActive(true);
        btn2_dilemme.gameObject.SetActive(true);
    }

    public void HandleClick1() // Gauche
    {
        if (save.IsIntersection())
        {
            CaseDisplay.SetActive(false);

            btn1_dilemme.gameObject.SetActive(false);
            btn2_dilemme.gameObject.SetActive(false);
            button.gameObject.SetActive(true);

            Movement.pathname = "J1_" + Movement.path_counter + "_LEFT";
            Movement.Play_iTween(GameObject.Find("Sphere_path"));
        }
    }

    public void HandleClick2() // Droite
    {
        if (save.IsIntersection())
        {
            CaseDisplay.SetActive(false);

            btn1_dilemme.gameObject.SetActive(false);
            btn2_dilemme.gameObject.SetActive(false);
            button.gameObject.SetActive(true);

            Movement.pathname = "J1_" + Movement.path_counter + "_RIGHT";
            Movement.Play_iTween(GameObject.Find("Sphere_path"));
            Move_counter();
        }
    }


    IEnumerator Action_Case(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        cases.Case_action();
    }

    public void Move_counter() // if bool = false it's left. Else its right
    {
        int j = save.Get_counter();
        //Debug.Log(" counter : " + j);

        if (j == 8)       { save.Set_counter(j + 2); } //right
        else if (j == 11) { save.Set_counter(j + 2); } 

        else if (j == 25) { save.Set_counter(j + 4); } //right
        else if (j == 30) { save.Set_counter(j + 4); }

        else if (j == 46) { save.Set_counter(j + 5); } // right
        else if (j == 52) { save.Set_counter(j + 4); }

        else if (j == 56) { save.Set_counter(j + 3); } //right
        else if (j == 60) { save.Set_counter(j + 2); }
    }

    void Move_advance() // if bool = false it's left. Else its right
    {
        int j = Movement.j;

        if (j == 8) { Movement.advance -= 2; Movement.j += 2; } //right
        else if (j == 11) { Movement.advance -= 2; Movement.j += 2; }

        else if (j == 25) { Movement.advance -= 4; Movement.j += 4; } //right
        else if (j == 30) { Movement.advance -= 4; Movement.j += 4; }

        else if (j == 46) { Movement.advance -= 5; Movement.j += 5; } // right
        else if (j == 52) { Movement.advance -= 4; Movement.j += 4; }

        else if (j == 56) { Movement.advance -= 3; Movement.j += 3; } //right
        else if (j == 60) { Movement.advance -= 2; Movement.j += 2; }
    }

    public bool IsStop()
    {
        int i = save.Get_counter();

        if (i == 4 || i == 16 || i == 24 || i == 42 || i == 62 || i == 68 || i == 84 || i == 91 || i == 100)
            return true;

        return false;
    }


    public bool Isleft(int i)
    {
        if (i == 9 || i == 10)
            return true;
        else if (i > 25 && i < 30)
            return true;
        else if (i > 46 && i < 52)
            return true;
        else if (i > 56 && i < 60)
            return true;

        return false;
    }
}
