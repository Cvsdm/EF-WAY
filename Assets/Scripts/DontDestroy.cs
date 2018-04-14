using UnityEngine;

public class DontDestroy : MonoBehaviour {

    public GameObject player;
    public GameObject terrain;
    //private GameObject ??;
	
	void Start () {
        DontDestroyOnLoad(player);
        DontDestroyOnLoad(terrain);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
