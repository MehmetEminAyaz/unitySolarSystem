using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class planetName : MonoBehaviour
{
    public TextMeshProUGUI planetNameText; // Gezegen ismini gösterecek Text bileþeni
    public Transform planet;               // Takip edilecek gezegenin transformu
    public Vector3 offset = new Vector3(0, 2, 0); // Gezegenin üzerinde konumlandýrma için bir ofset

    void Start()
    {
        // Tooltip baþlangýçta gizlenmiþ halde olacak
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
        // Fare gezegenin üzerine geldiðinde text'i aktif hale getir
        planetNameText.gameObject.SetActive(true);
        planetNameText.text = planet.name; // Gezegenin ismini text olarak ayarla
    }

    void OnMouseExit()
    {
        // Fare gezegenden ayrýldýðýnda text'i gizle
        planetNameText.gameObject.SetActive(false);
    }
}
