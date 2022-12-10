using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DJMusic : MonoBehaviour
{
    [SerializeField] private AudioClip _fonMusic;   
    [SerializeField] private AudioClip _kickHeadMusic;
    [SerializeField] private AudioClip _kickSwordMusic;

    public AudioSource FonAudioSorce;
    public AudioSource KnightAudioSorce;
    public AudioSource SwordAudioSorce;

    private void Start()
    {
        FonAudioSorce.clip = _fonMusic;
        FonAudioSorce.Play();

        KnightAudioSorce.clip = _kickHeadMusic;
        SwordAudioSorce.clip = _kickSwordMusic;
    }

   
}
 
