using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UI.Text;

public class CylinderScript : MonoBehaviour
{
    public GameObject belette;
    public Text Sonmez;
    public int nombre;
    public GameObject cible;
    // Start is called before the first frame update
    void Start()
    {
       
        cible.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Belette")
        {
            nombre = nombre + 1;
            Sonmez.text = "Belette = " + nombre;
            if (nombre == 10)
            {
                cible.SetActive(true);
            }
        }

    }
}
