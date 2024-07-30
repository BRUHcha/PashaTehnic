using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;

    public AudioSource _audioSource => GetComponent<AudioSource>();

    public void PlaySound(int min = 0, int max = 0, float volume = 0.5f)
    {
        int i = Random.Range(min,max);
        _audioSource.PlayOneShot(clips[i], volume);
    }
}
