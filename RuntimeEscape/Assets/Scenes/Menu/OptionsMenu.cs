using UnityEngine;
using UnityEngine.Audio;
public class OptionsMenu : MonoBehaviour
{

    public AudioMixer audioMixer;

    public void SetVolume (float Volume)
    {
        audioMixer.SetFloat("Volume", Volume);
    }
}