using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggered : MonoBehaviour {

    public bool was_triggered;
    public int intersection;

    private void Start()
    {
        was_triggered = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        if( !was_triggered )
        {
            was_triggered = true;
            Debug.Log("TRIGGERED");

            //StartCoroutine(WaitAndPause(0.5f));
            Movement.Stop_itween();

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
