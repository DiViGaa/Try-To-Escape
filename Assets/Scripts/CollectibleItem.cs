using UnityEngine;

public class CollectibleItem : MonoBehaviour
{
    public void DeactiveObject(Collider other)
    {
        other.gameObject.SetActive(false);
    }

    public void PlayPickUpSound(Collider other)
    {
        other.GetComponentInParent<AudioSource>().Play();
    }
}
