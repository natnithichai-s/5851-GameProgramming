using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private SoAudioClips walkAudioClips;
    [SerializeField] private SoAudioClips jumpAudioClips;
    [SerializeField] private SoAudioClips hurtAudioClips;
    [SerializeField] private SoAudioClips collectedAudioClips;
    [SerializeField] private SoAudioClips respawncollectibleAudioClips;
    [SerializeField] private SoAudioClips checkgroundAudioClips;
    [SerializeField] private SoAudioClips jumppadAudioClips;
    [SerializeField] private SoAudioClips finishAudioClips;

    public void PlayJumpSound()
    {
        audioSource.PlayOneShot(jumpAudioClips.GetAudioClips()); 
    }

    public void PlayWalkSound()
    {
        audioSource.PlayOneShot(walkAudioClips.GetAudioClips());
    }

    public void PlayHurtSound()
    {
        audioSource.PlayOneShot(hurtAudioClips.GetAudioClips());
    }

    public void PlayCollectedSound()
    {
        audioSource.PlayOneShot(collectedAudioClips.GetAudioClips());
    }
    
    public void PlayResapwnCollectibleSound()
    {
        audioSource.PlayOneShot(respawncollectibleAudioClips.GetAudioClips());
    }

    public void PlayCheckGroundSound()
    {
        audioSource.PlayOneShot(checkgroundAudioClips.GetAudioClips());
    }

    public void PlayJumppadSound()
    {
        audioSource.PlayOneShot(jumppadAudioClips.GetAudioClips());
    }

    public void PlayFinishSound()
    {
        audioSource.PlayOneShot(finishAudioClips.GetAudioClips());
    }
}