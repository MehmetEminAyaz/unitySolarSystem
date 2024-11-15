using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Orbit : MonoBehaviour
{
    public GameObject sun;  // G�ne� GameObject'ini referans al�yoruz
    public float orbitSpeed = 10f;  // Gezegenin ba�lang�� d�n�� h�z�
    public float orbitDistance = 10f;  // G�ne�e olan mesafe (y�r�nge yar��ap�)
    public float rotationSpeed = 30f;  // Gezegenin kendi etraf�nda d�nme h�z�

    private float speedMultiplier = 0.1f;  // H�z �arpan�

    void Start()
    {
        // Ba�lang��ta gezegenin G�ne� etraf�ndaki mesafesini ayarl�yoruz
        Vector3 orbitPosition = new Vector3(orbitDistance, 0, 0);
        transform.position = sun.transform.position + orbitPosition;
    }

    void Update()
    {
        // Gezegenin G�ne� etraf�nda d�nmesi i�in hareket
        OrbitAroundSun();

        // Gezegenin kendi etraf�nda d�nmesi
        RotateOnItsOwnAxis();
    }

    void OrbitAroundSun()
    {
        if (sun != null)
        {
            // Gezegenin her frame'de G�ne� etraf�nda d�nmesi
            transform.RotateAround(sun.transform.position, Vector3.up, orbitSpeed * speedMultiplier * Time.deltaTime);
        }
    }

    void RotateOnItsOwnAxis()
    {
        // Gezegenin kendi etraf�nda d�nmesi (�rne�in, Y ekseninde d�nmesini sa�l�yoruz)
        transform.Rotate(Vector3.up, rotationSpeed * speedMultiplier * Time.deltaTime);
    }

    // H�z �arpan�n� d��ar�dan g�ncelleyebilecek bir fonksiyon
    public void SetSpeedMultiplier(float multiplier)
    {
        speedMultiplier = multiplier;
    }
}
