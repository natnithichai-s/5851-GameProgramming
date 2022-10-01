using UnityEngine;

public class PlayerAnimatorEvent : MonoBehaviour
{
    [SerializeField] private PlayerAudioController audioController;

    public void PlayWalkSound()
    {
        audioController.PlayWalkSound();
    }

}
