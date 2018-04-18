using System.Collections;
using UnityEngine;

public class Triggered : MonoBehaviour {

    public bool was_triggered;
    public int intersection;
    private Sauvegarde save;
    //private int count = 0;
    private Cases cases;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
        cases = FindObjectOfType<Cases>();
        was_triggered = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if( !was_triggered )
        {
            was_triggered = true;

            //Debug.Log("Triggered");

            save.Set_counter(save.Get_counter() + 1);
            save.Set_nextmove(save.Get_nextmove() - 1);
            Debug.Log("counter : " + save.Get_counter());
            Debug.Log("next : " + save.Get_nextmove());


            //StartCoroutine(WaitAndPause(0.5f));
            if (save.Get_nextmove() == 0) /// Avance until the dice number
            {
                //Movement.Stop_itween();
                iTween.Stop();
                cases.Case_action(); //lancer la fonction de la case ds laquelle on a atteri
                save.Set_nextmove(4); //just pour les tests ^^
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

    IEnumerator WaitAndPause(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        // Code to execute after the delay
        //...
    }

}
