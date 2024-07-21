using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFX : MonoBehaviour
{
    public AudioSource spike;
    public AudioSource fakeout;
    public AudioSource victory;

    public void PlaySpike()
    {
    spike.Play();
    }
    public void PlayFake()
    {
        fakeout.Play();
    }
    public void PlayWin()
    {
       victory.Play();
    }
}
