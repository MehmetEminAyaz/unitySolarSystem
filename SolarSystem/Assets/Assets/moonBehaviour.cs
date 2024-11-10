using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moonBehaviour : MonoBehaviour
{
    public GameObject sun;  // Güneþ GameObject'ini referans alýyoruz
    public GameObject planet;  // Gezegen (örneðin Dünya)
    public GameObject moon;  // Ay GameObject'ini referans alýyoruz

    public float orbitSpeed = 10f;  // Gezegenin dönüþ hýzý
    public float orbitDistance = 10f;  // Güneþe olan mesafe (yörünge yarýçapý)

    public float moonOrbitSpeed = 15f;  // Ay'ýn Dünya etrafýnda dönüþ hýzý
    public float moonOrbitDistance = 2f;  // Ay'ýn Dünya'ya olan mesafesi (yörünge yarýçapý)

    void Start()
    {
        // Baþlangýçta gezegenin (Dünya) Güneþ etrafýndaki mesafesini ayarlýyoruz
        Vector3 orbitPosition = new Vector3(orbitDistance, 0, 0);
        planet.transform.position = sun.transform.position + orbitPosition;

        // Ay'ýn Dünya etrafýndaki mesafesini ayarlýyoruz
        Vector3 moonOrbitPosition = new Vector3(moonOrbitDistance, 0, 0);
        moon.transform.position = planet.transform.position + moonOrbitPosition;
    }

    void Update()
    {
        // Gezegenin (Dünya) Güneþ etrafýnda dönmesini saðlýyoruz
        OrbitAroundSun();

        // Ay'ýn Dünya etrafýnda dönmesini saðlýyoruz
        OrbitAroundPlanet();
    }

    void OrbitAroundSun()
    {
        if (sun != null && planet != null)
        {
            // Gezegenin her frame'de Güneþ etrafýnda dönmesi
            planet.transform.RotateAround(sun.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }

    void OrbitAroundPlanet()
    {
        if (planet != null && moon != null)
        {
            // Ay'ýn her frame'de Dünya etrafýnda dönmesi
            moon.transform.RotateAround(planet.transform.position, Vector3.up, moonOrbitSpeed * Time.deltaTime);
        }
    }
}
