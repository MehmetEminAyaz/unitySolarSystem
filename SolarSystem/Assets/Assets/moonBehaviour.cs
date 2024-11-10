using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonBehaviour : MonoBehaviour
{
    public GameObject sun;  // G�ne� GameObject'ini referans al�yoruz
    public GameObject planet;  // Gezegen (�rne�in D�nya)
    public GameObject moon;  // Ay GameObject'ini referans al�yoruz

    public float orbitSpeed = 10f;  // Gezegenin d�n�� h�z�
    public float orbitDistance = 10f;  // G�ne�e olan mesafe (y�r�nge yar��ap�)

    public float moonOrbitSpeed = 15f;  // Ay'�n D�nya etraf�nda d�n�� h�z�
    public float moonOrbitDistance = 2f;  // Ay'�n D�nya'ya olan mesafesi (y�r�nge yar��ap�)

    void Start()
    {
        // Ba�lang��ta gezegenin (D�nya) G�ne� etraf�ndaki mesafesini ayarl�yoruz
        Vector3 orbitPosition = new Vector3(orbitDistance, 0, 0);
        planet.transform.position = sun.transform.position + orbitPosition;

        // Ay'�n D�nya etraf�ndaki mesafesini ayarl�yoruz
        Vector3 moonOrbitPosition = new Vector3(moonOrbitDistance, 0, 0);
        moon.transform.position = planet.transform.position + moonOrbitPosition;
    }

    void Update()
    {
        // Gezegenin (D�nya) G�ne� etraf�nda d�nmesini sa�l�yoruz
        OrbitAroundSun();

        // Ay'�n D�nya etraf�nda d�nmesini sa�l�yoruz
        OrbitAroundPlanet();
    }

    void OrbitAroundSun()
    {
        if (sun != null && planet != null)
        {
            // Gezegenin her frame'de G�ne� etraf�nda d�nmesi
            planet.transform.RotateAround(sun.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }

    void OrbitAroundPlanet()
    {
        if (planet != null && moon != null)
        {
            // Ay'�n her frame'de D�nya etraf�nda d�nmesi
            moon.transform.RotateAround(planet.transform.position, Vector3.up, moonOrbitSpeed * Time.deltaTime);
        }
    }
}
