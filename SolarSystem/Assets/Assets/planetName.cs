using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class planetName : MonoBehaviour
{
    public TextMeshProUGUI planetNameText; // Gezegen ismini g�sterecek Text bile�eni
    public Transform planet;               // Takip edilecek gezegenin transformu
    public Vector3 offset = new Vector3(0, 2, 0); // Gezegenin �zerinde konumland�rma i�in bir ofset

    void Start()
    {
        // Tooltip ba�lang��ta gizlenmi� halde olacak
        planetNameText.gameObject.SetActive(false);
    }

    void Update()
    {
        // Tooltip gezegenin pozisyonunu takip edecek
        Vector3 screenPosition = Camera.main.WorldToScreenPoint(planet.position + offset);
        planetNameText.transform.position = screenPosition;
    }

    void OnMouseEnter()
    {
        // Fare gezegenin �zerine geldi�inde text'i aktif hale getir
        planetNameText.gameObject.SetActive(true);
        planetNameText.text = planet.name; // Gezegenin ismini text olarak ayarla
    }

    void OnMouseExit()
    {
        // Fare gezegenden ayr�ld���nda text'i gizle
        planetNameText.gameObject.SetActive(false);
    }
}
