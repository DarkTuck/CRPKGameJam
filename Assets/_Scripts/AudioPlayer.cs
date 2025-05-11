using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    [SerializeField] AudioSource m_AudioSource;
    private static AudioPlayer instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    public static void PlayClip(AudioClip clip)
    {
        instance.m_AudioSource.clip = clip;
        instance.m_AudioSource.Play();
    }
}
