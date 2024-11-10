using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planetSpeed : MonoBehaviour
{
    public List<Orbit> planets;  // T�m gezegenleri i�eren bir liste
    public Slider speedSlider;   // SliderSpeed slider'�n� referans al�yoruz

    void Start()
    {
        // Slider de�i�tirildi�inde, t�m gezegenlerin h�z �arpan�n� g�ncelle
        speedSlider.onValueChanged.AddListener(UpdatePlanetSpeeds);
    }

    // Slider de�eri de�i�tik�e bu fonksiyon �al���r
    void UpdatePlanetSpeeds(float multiplier)
    {
        foreach (Orbit planet in planets)
        {
            planet.SetSpeedMultiplier(multiplier);
        }
    }
}
