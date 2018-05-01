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

            //Debug.Log("Triggered");

            /*if (Movement.advance != -1)
            {

            }*/
            if (Movement.advance == 0)
            {
               // Debug.Log("Je ne veux pas être là!!");
                //Debug.Log("advance = 0");
                if (save.Get_nextmove() != 0)
                {
                    save.Set_counter(save.Get_counter() + 1);
                    save.Set_nextmove(save.Get_nextmove() - 1);
                }

                if (save.Get_nextmove() == 0) /// Avance until the dice number
                {
                    //Movement.Stop_itween();
                    //iTween.Stop();
                    iTween.Pause();
                    cases.Case_action(); //lancer la fonction de la case ds laquelle on a atteri
                    //save.Set_nextmove(4); //just pour les tests ^^
                }
            }
            else
            {
                //Debug.Log("advance =/ 0");
                Movement.advance = Movement.advance - 1;
                //Debug.Log("advanced : " + Movement.advance);
                if (Movement.advance == 0)
                {
                    iTween.Pause();
                    //StartCoroutine(WaitAndPause(0.5f));
                    //Movement.Play_iTween(other.gameObject);
                    //iTween.Resume();
                }

            }
                
            //Debug.Log("counter : " + save.Get_counter());
            //Debug.Log("next : " + save.Get_nextmove());


            //StartCoroutine(WaitAndPause(0.1f));


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

    IEnumerator WaitAndPause(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Debug.Log("ca devra se lancer ...");
        iTween.Resume();
        //Movement.Play_iTween(other.gameObject);
    }

}
