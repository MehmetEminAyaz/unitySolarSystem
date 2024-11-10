using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSound : MonoBehaviour
{
    public AudioClip planetSound;  // Gezegenin ses kayd�n� tutacak de�i�ken

    void OnMouseDown()
    {
        // AudioManager'dan sesi �almay� �a��r�yoruz
        AudioManager.instance.PlayPlanetSound(planetSound);
    }
}
