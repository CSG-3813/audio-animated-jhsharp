using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostScript : MonoBehaviour
{
    public Animator animator;
    public AudioClip audioClip;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetTrigger("InRange");
        
        // don't repeat audio if it is already playing
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(audioClip);
        }
    }
}
