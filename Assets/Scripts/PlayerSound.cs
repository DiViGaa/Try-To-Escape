using UnityEngine;

public class PlayerSound : MonoBehaviour
{
    [SerializeField] private AudioClip runClip;
    [SerializeField] private AudioClip jumpClip;
    [SerializeField] private AudioClip deathClip;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponentInParent<AudioSource>();
    }

    public void PlayRun()
    {
        audioSource.PlayOneShot(runClip);
    }

    public void PlayJump()
    {
        audioSource.PlayOneShot(jumpClip);
    }

    public void Death() 
    { 
        audioSource.PlayOneShot(deathClip);
    }
}
