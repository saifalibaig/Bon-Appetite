using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Unity.Mathematics;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;
    public Sounds[] musicSounds, sfxSounds;
    public AudioSource musicSource, sfxSource;

    public void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        PlayMusic("Theme");
    }

    public void StopMusic()
    {
        musicSource.Stop();
    }


    public void PlayMusic(string name)
    {
        Sounds s = Array.Find(musicSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("sound not found");

        }
        else
        {
            musicSource.clip = s.clip;
            musicSource.Play();

        }
    }
    public void PlaySFX(string name)
    {
        Sounds s = Array.Find(sfxSounds, x => x.name == name);

        if (s == null)
        {
            Debug.Log("sound not found");

        }
        else
        {
            sfxSource.PlayOneShot(s.clip);


        }
    }


    public void ToggleMusic()
    {
        musicSource.mute = !musicSource.mute;
    }

    public void ToggleSFX()
    {
        sfxSource.mute = !sfxSource.mute;
    }

    public void MusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    public void SFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }
}
