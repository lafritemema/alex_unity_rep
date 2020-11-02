using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public OVRInput.Button boutonOuvrirMenu;
    public OVRInput.Button boutonFermeMenu;
    public GameObject canvas;
    public GameObject canvasBibli;
    public GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(false);
        canvasBibli.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }


        if (OVRInput.GetDown(boutonOuvrirMenu, OVRInput.Controller.LTouch)){
            canvas.SetActive(true);
            
        }

     /*   if (OVRInput.GetDown(boutonFermeMenu, OVRInput.Controller.LTouch))
        {
            canvas.SetActive(false);

        }*/
        canvas.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + 1.5f);
        canvasBibli.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + 1.5f);
    }

    public void menuReprendre()
    {
        canvas.SetActive(false);
    }


    public void menuQuitter()
    {
        Application.Quit();
    }

    public void menuBibli()
    {
        canvas.SetActive(false);
        canvasBibli.SetActive(true);
    }
    
    public void bibliRetour()
    {
        canvasBibli.SetActive(false);
        canvas.SetActive(true);
    }
}
