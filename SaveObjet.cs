using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveObjet : MonoBehaviour
{
    RaycastHit hit;
    public OVRInput.Button boutonValide;
    protected string objetRecupere;
    public GameObject canvasClavier;
    public Text textCanvas;
    bool VraiFaux = false;
    bool VraiFauxSecond = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (OVRInput.GetDown(boutonValide, OVRInput.Controller.LTouch))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
            {
                objetRecupere = hit.collider.gameObject.name;
                VraiFauxSecond = true;
                UnityEngine.Debug.Log("force rouge");
            }
        }

        if (VraiFauxSecond == true)
        {
            TexteDuCanvas();
            UnityEngine.Debug.Log("force rose");
        }

        if (VraiFaux == true)
        {
            PlayerPrefs.SetString(textCanvas.GetComponent<Text>().text, objetRecupere);
            VraiFaux = false;
            UnityEngine.Debug.Log("force bleu");
        }
    }

    protected void TexteDuCanvas()
    {
        canvasClavier.SetActive(true);

            if (OVRInput.GetDown(boutonValide, OVRInput.Controller.RTouch))
            {
                VraiFaux = true;
                canvasClavier.SetActive(false);
            UnityEngine.Debug.Log("force jaune");

        }
        
    }
}

/*
                TexteDuCanvas();
                PlayerPrefs.SetString(textCanvas.GetComponent<Text>().text, hit.collider.gameObject.name);
                UnityEngine.Debug.Log("Job, is, done");
 */
