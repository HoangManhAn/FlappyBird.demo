using System.Collections;
using UnityEngine;


public class AudioCtrl : MonoBehaviour
{
    public AudioClip flapClip;
    public AudioClip pointClip;
    public AudioClip dieClip;

    private AudioSource audioSource;

    private static AudioCtrl instance;
    public static AudioCtrl Instance => instance;

    private void Awake()
    {
        if (AudioCtrl.instance != null)
        {
            Debug.LogError("Only one AudioCtrl allow to exist");
            Destroy(gameObject);
        }
        AudioCtrl.instance = this;
    }

    protected void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void FlapAudio()
    {
        audioSource.clip = flapClip;
        audioSource.Play();
    }

    public void DieAudio()
    {
        audioSource.clip = dieClip;
        audioSource.Play();
    }

    public void PointAudio()
    {
        audioSource.clip = pointClip;
        audioSource.Play();
    }

}
