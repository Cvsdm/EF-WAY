using UnityEngine;

public class Movement : MonoBehaviour
{

    public static string pathname; //pathname format : jPlayerNB_PathNB, 
                                   // Or jPlayerNB_PathNB_RIGHT (/LEFT) 
    public static int path_counter;
    private Sauvegarde save;
    public static int advance;
    //static private GameObject j1;

    void Start()
    {
        pathname = "j1_1";
        path_counter = 1;
        save = FindObjectOfType<Sauvegarde>();
        advance = save.Get_counter();
        //Debug.Log("advanced" + advance);
        if (advance != 0)
            Play_Start_iTween(this.gameObject);
    }

    public static void Play_iTween(GameObject j1)
    {
        iTween.MoveTo(j1, iTween.Hash("path", iTweenPath.GetPath(pathname),
                                              "speed", 10,
                                              "easeType", iTween.EaseType.easeInOutSine)
                     );
    }

    public static void Play_Start_iTween(GameObject j1)
    {
        iTween.MoveTo(j1, iTween.Hash("path", iTweenPath.GetPath(pathname),
                                              "speed", 100,
                                              "easeType", iTween.EaseType.easeInOutSine)
                     );
    }
}
