using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;  // Singleton örneði
    private AudioSource audioSource;  // Ses kaydýný çalacak AudioSource

    void Awake()
    {
        // Singleton pattern: Yalnýzca bir instance olmasý saðlanýr
        if (instance == null)
        {
            instance = this;  // Bu instance'ý static olarak ayarla
            DontDestroyOnLoad(gameObject);  // Sahne deðiþse bile bu objenin yok olmamasý saðlanýr
        }
        else
        {
            Destroy(gameObject);  // Eðer baþka bir instance varsa, bu objeyi yok et
        }

        audioSource = GetComponent<AudioSource>();  // AudioSource bileþenini al
    }

    public void PlayPlanetSound(AudioClip clip)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();  // Eðer bir ses çalýyorsa, önce durdur
        }
        audioSource.clip = clip;  // Yeni ses kaydýný seç
        audioSource.Play();  // Yeni ses kaydýný çalmaya baþla
    }
}
