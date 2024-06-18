using UnityEngine;

public class SoundUI : MonoBehaviour
{
    [SerializeField] private AudioClip hoverClip;
    [SerializeField] private AudioClip pressedClip;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponentInParent<AudioSource>();
    }

    public void PlayHover()
    {
        audioSource.PlayOneShot(hoverClip);
    }

    public void PlayPressed()
    {
        audioSource.PlayOneShot(pressedClip);
    }
}
