using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicArray;

    private AudioSource audioSource;
    
    void Awake ()
    {
        DontDestroyOnLoad(gameObject);
        Debug.Log("Loaded " + name);
	}

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicArray[level];
        Debug.Log("Loaded music " + thisLevelMusic);
        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }

    }

    public void SetMusicLevel(float volume)
    {
        audioSource.volume = volume;
    }
}
