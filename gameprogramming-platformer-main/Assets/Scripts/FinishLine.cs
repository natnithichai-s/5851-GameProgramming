using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private PlayerAudioController audioController;
    [SerializeField] private ParticleSystem Dust;
    
    private const string PlayerTag = "Player";

    private GameManager _gameManager;
    
    // Why are we checking if the player reaches the finish line here? So, we do not
    // have to check for every time the player collides with something for a finish line.
    
    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();
    }
    
    public void OnTriggerEnter2D(Collider2D col)
    {
        if (!col.CompareTag(PlayerTag)) return;
        GateGoBoom();
        audioController.PlayFinishSound();
        _gameManager.LoadNextLevel();
    }

    public void GateGoBoom()
    {
        Dust.Play();
    }

}
