using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voice : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;

    public void clicSound()
    {
        audio.PlayOneShot(clip);
    }
}
