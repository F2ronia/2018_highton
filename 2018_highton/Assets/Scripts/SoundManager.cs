using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioClip fireSnd;
    //
    private AudioSource audio;
    //

    public static SoundManager instance;

    private void Awake()
    {
        if (SoundManager.instance == null)
            SoundManager.instance = this;
    }

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void PlayFireSound()
    {
        audio.PlayOneShot(fireSnd);
    }
}
