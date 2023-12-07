using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioSource source;
    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    public static void PlaySound(AudioClip _audio)
    {
        source.clip = _audio;
        source.Play();
    }
}
