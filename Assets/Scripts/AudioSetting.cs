using UnityEngine;
using UnityEngine.Audio;

public class AudioSetting : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup mixerGroup;

    public void ChangeMasterValue(float volume)
    {
        mixerGroup.audioMixer.SetFloat("Master", Mathf.Lerp(-80, 0, volume));
    }
    public void ChangeEnviromentValue(float volume)
    {
        mixerGroup.audioMixer.SetFloat("Enviroments", Mathf.Lerp(-80, -30, volume));
    }
    public void ChangeMusicValue(float volume)
    {
        mixerGroup.audioMixer.SetFloat("Music", Mathf.Lerp(-80, 0, volume));
    }
    public void ChangeSystemValue(float volume)
    {
        mixerGroup.audioMixer.SetFloat("System", Mathf.Lerp(-80, -30, volume));
    }
}
