using UnityEngine;

public class AudioManager : MonoBehaviour
{
  private AudioSource systemSource;
  private List<AudioSource> activeSources;




    #region Singleton Logic
        private void Awake()
        {
        if (instance == null)
        {
            Instance = this;
            DontDestroyOnLoad (gameObject);
            systemSource = GetComponent<AudioSource>();
            activeSources = new List<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
        }
    #endregion
    
    public void Play(AudioClip clip, AudioSource source)
    {
        if (!activeSources.Contains(source))
                activeSources.Add(source);
        systemSource.Stop();
        systemSource.clip = clip;
        systemSource.Play();
    }

   public void PlayOneShot(AudioClip clip)
    {
        systemSource.PlayOneShot(clip);
    }

    public void PlaySound(AudioClip clip)
    {
        audioSource.Stop();
        audioSource.clip = clip;
        audioSource.Play();

    }

    public void Stop(AudioSource source)
    {
            if(activeSources.Contains(source))
                activeSources.remove(source);
                source.Stop();
    }

    public void Stop()
    {
        audioSource.Stop;
    }

    public void Pause()
    {
        audioSource.Pause;
    }

    public void Resume()
    {
        audioSource.UnPause;
    }

}
 


 

   