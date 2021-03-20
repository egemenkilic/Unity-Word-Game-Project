using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sound : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip clip;

    private void Awake()
    {
        foreach(Button obj in Resources.FindObjectsOfTypeAll<Button>())
        {
            obj.onClick.AddListener(() => playSound());
        }
    }

    public void playSound()
    {
        audio.PlayOneShot(clip,1);
    }
}
