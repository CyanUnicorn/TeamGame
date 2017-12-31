using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicmanager : MonoBehaviour {
    public AudioClip[] levelmusicchange;
    private AudioSource audiosource;
    // Use this for initialization
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        
    }
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();   
    }
    // Update is called once per frame
    void OnLevelWasLoaded (int level) {
        AudioClip thislevelmusic = levelmusicchange[level];

        if (levelmusicchange[level])
        {
            audiosource.clip = thislevelmusic;
            audiosource.loop = true;
            audiosource.Play();
        }
	}
    public void ChangeVolume(float level)
    {
        audiosource.volume = level; 
    }
}
