using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public static AudioManager Instance;
    
    [SerializeField] AudioSource audioSource;
    [SerializeField] private List<AudioClip> audioClips;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void PlayClip(int clipIndex)
    {
        audioSource.PlayOneShot(audioClips[clipIndex]);
        audioSource.Play();
    }

    public void StopClip(int clipIndex)
    {
        audioSource.Stop();
        audioSource.clip = null;
    }
}
