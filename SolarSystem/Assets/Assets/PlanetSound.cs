using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSound : MonoBehaviour
{
    public AudioClip planetSound;  // Gezegenin ses kaydýný tutacak deðiþken

    void OnMouseDown()
    {
        // AudioManager'dan sesi çalmayý çaðýrýyoruz
        AudioManager.instance.PlayPlanetSound(planetSound);
    }
}
