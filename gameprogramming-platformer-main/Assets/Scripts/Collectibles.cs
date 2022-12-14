using UnityEngine;

public class Collectibles : MonoBehaviour
{
    [SerializeField] private CollectibleSpawner collectibleSpawner;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private SoCollectibles collectibleObject;
    [SerializeField] private PlayerAudioController audioController;
    [SerializeField] private ParticleSystem CollectiblesDust;
    
    private CollectibleType _collectibleType;
    private bool _isRespawnable;

    private void Start()
    {
        SetCollectible();
    }

    public CollectibleType GetCollectibleInfoOnContact()
    {
        gameObject.SetActive(false);
        CollectiDust();
        
        if (_isRespawnable)
        {
            collectibleSpawner.StartRespawningCountdown();
        }

        return _collectibleType;
    }
    
    private void SetCollectible()
    {
        collectibleSpawner.SetOutlineSprite(collectibleObject.GetOutlineSprite());
        spriteRenderer.sprite = collectibleObject.GetSprite();
        _collectibleType = collectibleObject.GetCollectibleType();
        _isRespawnable = collectibleObject.GetRespawnable();
    }

    public void CollectiDust()
    {
        CollectiblesDust.Play();
    }
}
