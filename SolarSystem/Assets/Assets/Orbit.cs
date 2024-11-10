using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    public GameObject sun;  // Güneþ GameObject'ini referans alýyoruz
    public float orbitSpeed = 10f;  // Gezegenin dönüþ hýzý
    public float orbitDistance = 10f;  // Güneþe olan mesafe (yörünge yarýçapý)
    public float rotationSpeed = 30f;  // Gezegenin kendi etrafýnda dönme hýzý

    void Start()
    {
        // Baþlangýçta gezegenin Güneþ etrafýndaki mesafesini ayarlýyoruz
        Vector3 orbitPosition = new Vector3(orbitDistance, 0, 0);
        transform.position = sun.transform.position + orbitPosition;
    }

    void Update()
    {
        // Gezegenin Güneþ etrafýnda dönmesi için hareket
        OrbitAroundSun();

        // Gezegenin kendi etrafýnda dönmesi
        RotateOnItsOwnAxis();
    }

    void OrbitAroundSun()
    {
        if (sun != null)
        {
            // Gezegenin her frame'de Güneþ etrafýnda dönmesi
            transform.RotateAround(sun.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }

    void RotateOnItsOwnAxis()
    {
        // Gezegenin kendi etrafýnda dönmesi (örneðin, Y ekseninde dönmesini saðlýyoruz)
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
