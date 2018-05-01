using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {
    public Image Sound;
    public Sprite spriteMute, spriteUnmute;
    private AudioSource music;
	// Use this for initialization
	void Start () {
        music = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
	}
	


    public void ToggleMuteMusic()
    {
            if (music.mute)
            {
                music.mute = false;//mettre en unmute
                Sound.sprite = spriteUnmute;
            }
            else
            {
                music.mute = true;// mettre en mute
                Sound.sprite = spriteMute;
            }
       

    }
}
