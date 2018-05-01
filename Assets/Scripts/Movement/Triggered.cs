using System.Collections;
using UnityEngine;

public class Triggered : MonoBehaviour {

    public bool was_triggered;
    public int intersection;
    private Sauvegarde save;
    private Cases cases;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        cases = FindObjectOfType<Cases>();
        was_triggered = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(!was_triggered)
        {
            was_triggered = true;

            if (Movement.advance == 0)
            {
                if (save.Get_nextmove() != 0)
                {
                    save.Set_counter(save.Get_counter() + 1);
                    save.Set_nextmove(save.Get_nextmove() - 1);
                }

                if (save.Get_nextmove() == 0) /// Avance until the dice number
                {
                    iTween.Pause();
                    StartCoroutine(Action_Case(0.8f)); //lancer l'action de la case
                }
            }
            else
            {
                Movement.advance = Movement.advance - 1;
                if (Movement.advance == 0)
                {
                    iTween.Pause();
                }

            }
                

            if (this.name.Length >= 10) // ex : P1_ENDPATH
            {
                Movement.path_counter += 1;

                if (this.intersection == 1)
                    Movement.pathname = "J1_" + Movement.path_counter + "_LEFT";
                else
                    Movement.pathname = "J1_" + Movement.path_counter;

                Movement.Play_iTween(other.gameObject);
            }
        }
    }

    IEnumerator Action_Case(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        cases.Case_action();
    }

}
