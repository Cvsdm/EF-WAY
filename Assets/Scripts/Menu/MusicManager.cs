using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {
    public Image Sound;
    public Sprite spriteMute, spriteUnmute;
    private AudioSource music;
    public static MusicManager instance;

	void Start ()
    {
        music = FindObjectOfType<AudioSource>();

        if (instance == null) //Check if there is already an instance of SoundManager            
        {
            instance = this; //if not, set it to this.
            music.Play();
            DontDestroyOnLoad(gameObject);
        }        
    }

    public void ToggleMuteMusic()
    {
            if (music.mute)
            {
                Debug.Log("unmute");
                music.mute = false;//mettre en unmute
                Sound.sprite = spriteUnmute;
            }
            else
            {
                Debug.Log("mute");
                music.mute = true;// mettre en mute
                Sound.sprite = spriteMute;
            }
    }
}
