using UnityEngine;

public class Movement : MonoBehaviour
{

    public static string pathname; //pathname format : jPlayerNB_PathNB, 
                                   // Or jPlayerNB_PathNB_RIGHT (/LEFT) 
    public static int path_counter;

    void Start()
    {
        pathname = "j1_1";
        path_counter = 1;
        Play_iTween(this.gameObject);
    }

    public static void Play_iTween( GameObject j1 )
    {
        iTween.MoveTo(j1, iTween.Hash("path", iTweenPath.GetPath(pathname),
                                              "speed", 10,
                                              "easeType", iTween.EaseType.easeInOutSine)
                     );
    }

    public static void Stop_itween()
    {
        //Debug.Log("STOP!");
        iTween.Pause();
    }

    private void OnMouseOver()
    {
        iTween.Resume();
    }
}
