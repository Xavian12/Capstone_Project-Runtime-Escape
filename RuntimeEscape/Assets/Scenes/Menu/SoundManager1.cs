using System.Numerics;
using UnityEngine;

public class SoundManager1 : MonoBehaviour
{
    public static SoundManager1 Instance;

    [SerializeField]
    private SoundLibrary sfxLibrary;
    [SerializeField]
    private AudioSource sfx2DSource;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlaySound3D(AudioClip clip, UnityEngine.Vector3 pos)
    {
        if (clip != null)
        {
            AudioSource.PlayClipAtPoint(clip, pos);
        }
    }

    public void PlaySound3D(string soundname, UnityEngine.Vector3 pos)
    {
        PlaySound3D(sfxLibrary.GetClipFromName(soundname), pos); 
    }

    public void PLaySound2D(string soundName)
    {
        sfx2DSource.PlayOneShot(sfxLibrary.GetClipFromName(soundName));
    }
}