using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PianoControl : MonoBehaviour
{
    public List<GameObject> whiteKeys = new List<GameObject>();
    public List<GameObject> blackKeys = new List<GameObject>();

    public List<AudioClip> whiteKeySounds = new List<AudioClip>();
    public List<AudioClip> blackKeySounds = new List<AudioClip>();

    AudioSource audioSource = new AudioSource();

    public void PlayWhiteKey(int key)
    {
        
    }
}
