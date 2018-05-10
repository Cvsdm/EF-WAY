using UnityEngine;

public class Movement : MonoBehaviour
{
    public static string pathname; //pathname format : jPlayerNB_PathNB, 
                                   // Or jPlayerNB_PathNB_RIGHT (/LEFT) 
    public static int path_counter;
    private Sauvegarde save;
    public static int advance;
    public static int j = 0;
    public static bool flag = false;

    void Start()
    {
        pathname = "j1_1";
        path_counter = 1;
        save = FindObjectOfType<Sauvegarde>();
        save.Find_dice();
        advance = save.Get_counter();
        if (advance != 0)
        {
            Play_iTween(this.gameObject);
            Sauvegarde.dices.gameObject.SetActive(false);
        }
    }

    public static void Play_iTween(GameObject j1)
    {
        iTween.MoveTo(j1, iTween.Hash("path", iTweenPath.GetPath(pathname),
                                              "speed", 10,
                                              "easeType", iTween.EaseType.easeInOutSine)
                     );
    }
}
