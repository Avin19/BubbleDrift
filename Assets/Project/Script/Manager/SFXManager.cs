using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;
    [Header("Audios")]
    [SerializeField] private AudioClip popUpAudio;
    [SerializeField] private AudioClip bubbleSpawnAudio;
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

    public void PlayPopUp() => sfxManager.PlayOneShot(popUpAudio);
    public void BubbleSpawnAudio() => sfxManager.PlayOneShot(bubbleSpawnAudio);

}