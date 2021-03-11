﻿using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioMixer master;
    public Sound[] sounds;
    // Start is called before the first frame update
    void Awake()
    {
        foreach(Sound s in sounds){
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
            s.source.outputAudioMixerGroup = master.FindMatchingGroups("Master")[0];
        }
    }

    public void PlaySound(string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null){
            return;
        }
        s.source.Play();
    }

    public void StopSound(string name){
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if(s == null){
            return;
        }
        s.source.Stop();
    }
}
