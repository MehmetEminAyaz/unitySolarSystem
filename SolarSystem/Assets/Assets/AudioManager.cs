using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;  // Singleton �rne�i
    private AudioSource audioSource;  // Ses kayd�n� �alacak AudioSource

    void Awake()
    {
        // Singleton pattern: Yaln�zca bir instance olmas� sa�lan�r
        if (instance == null)
        {
            instance = this;  // Bu instance'� static olarak ayarla
            DontDestroyOnLoad(gameObject);  // Sahne de�i�se bile bu objenin yok olmamas� sa�lan�r
        }
        else
        {
            Destroy(gameObject);  // E�er ba�ka bir instance varsa, bu objeyi yok et
        }

        audioSource = GetComponent<AudioSource>();  // AudioSource bile�enini al
    }

    public void PlayPlanetSound(AudioClip clip)
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();  // E�er bir ses �al�yorsa, �nce durdur
        }
        audioSource.clip = clip;  // Yeni ses kayd�n� se�
        audioSource.Play();  // Yeni ses kayd�n� �almaya ba�la
    }
}
