 using UnityEngine;

public class CollisionBarrier : MonoBehaviour
{
    [SerializeField] private GameUI _gameUI;
    [SerializeField] private GameOver gameOver;

    private CharacterController _characterController;
    private CollectibleItem _collectibleItem;
    private PlayerAnimator _playerAnimator;
    
    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _playerAnimator = GetComponent<PlayerAnimator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Barrier"))
        {
            BarrierGameOver(other);
        }
        else if (other.gameObject.CompareTag("FallTrigger"))
        {
            FallGamgeOver();
        }
        else if (other.gameObject.CompareTag("Bush"))
        {
            PlayBushSound(other);
        }
        else if(other.gameObject.CompareTag("Coin"))
        {
            CollisionWithACoin(other);
        }
    }

    private void BarrierGameOver(Collider other)
    {
        if (ComponentCollectibleItemOnSite(other))
        {
            _collectibleItem = other.GetComponent<CollectibleItem>();
        }
        _gameUI.UpdateGlobalBottleCounter();
        _playerAnimator.CollisionBarrier();
        gameOver.GameOverCollisionOrFall();
    }

    private CollectibleItem ComponentCollectibleItemOnSite(Collider other)
    {
        return other.gameObject.GetComponent<CollectibleItem>();
    }

    private void FallGamgeOver()
    {
        _characterController.Move(new Vector3(4, 0, 0));
        _playerAnimator.Fall();
        gameOver.GameOverCollisionOrFall();
    }
    private static void PlayBushSound(Collider other)

    {
        other.GetComponent<AudioSource>().Play();
    }

    private void CollisionWithACoin(Collider other)
    {
        _collectibleItem = other.GetComponent<CollectibleItem>();
        _gameUI.UpdateLocalBottleCounter();
        _collectibleItem.PlayPickUpSound(other);
        _collectibleItem.DeactiveObject(other);
    }

}
