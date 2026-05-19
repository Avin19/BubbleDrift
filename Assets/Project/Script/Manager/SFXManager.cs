using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;
    [Header("Audios")]

    private AudioSource sfxManager;


    void Awake()
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
        sfxManager = GetComponent<AudioSource>();
    }

    public void PlaySfX(AudioClip _audioClip) => sfxManager.PlayOneShot(_audioClip);


}