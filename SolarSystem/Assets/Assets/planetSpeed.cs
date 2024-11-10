using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class planetSpeed : MonoBehaviour
{
    public List<Orbit> planets;  // Tüm gezegenleri içeren bir liste
    public Slider speedSlider;   // SliderSpeed slider'ýný referans alýyoruz

    void Start()
    {
        // Slider deðiþtirildiðinde, tüm gezegenlerin hýz çarpanýný güncelle
        speedSlider.onValueChanged.AddListener(UpdatePlanetSpeeds);
    }

    // Slider deðeri deðiþtikçe bu fonksiyon çalýþýr
    void UpdatePlanetSpeeds(float multiplier)
    {
        foreach (Orbit planet in planets)
        {
            planet.SetSpeedMultiplier(multiplier);
        }
    }
}
