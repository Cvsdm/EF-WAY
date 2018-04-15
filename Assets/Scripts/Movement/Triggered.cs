using System.Collections;
using UnityEngine;

public class Triggered : MonoBehaviour {

    public bool was_triggered;
    public int intersection;
    private Sauvegarde save;
    //private int count = 0;

    private void Start()
    {
        save = FindObjectOfType<Sauvegarde>();
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


             //StartCoroutine(WaitAndPause(0.5f));
             if (save.Get_nextmove() == 0)
            {
                Movement.Stop_itween();
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
            //Destroy(gameObject, 0);
        }
    }

    IEnumerator WaitAndPause(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        // Code to execute after the delay
        //...
    }

}
