using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicManager : MonoBehaviour {
    public Image Sound;
    public Sprite spriteMute, spriteUnmute;
    private AudioSource music;
    public static bool instance = false;

	void Start ()
    {
        if (!instance)
        {
            instance = true;
            music = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
            Debug.Log("music :D");
        }
        else
            music = FindObjectOfType<AudioSource>();
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
