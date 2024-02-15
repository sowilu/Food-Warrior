using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private AudioSource audio;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        audio = GetComponent<AudioSource>();
    }

    public void Play(AudioClip clip, float pitch = 1, float volume = 0.5f)
    {
        audio.pitch = pitch;
        audio.volume = volume;

        audio.PlayOneShot(clip);
    }
}
