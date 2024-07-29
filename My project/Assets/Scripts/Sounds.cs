using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;

    public AudioSource _audioSource => GetComponent<AudioSource>();

    public void PlaySound(float volume = 0.5f)
    {
        int i = Random.Range(0,clips.Length);
        _audioSource.PlayOneShot(clips[i], volume);
    }
}
