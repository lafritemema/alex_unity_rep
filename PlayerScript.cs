using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{

    public OVRInput.Button boutonOuvrirMenu;
  //  public OVRInput.Button boutonFermeMenu;
    public GameObject canvas;
    public GameObject canvasBibli;
    public GameObject canvasClavier;
    public GameObject camera;
    public GameObject player;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject cylinder;
    public GameObject canvasSousMenu;

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
            rightHand.GetComponent<ActiverDeplacement>().enabled = false;
            Time.timeScale = 0;
            
        }
        /* Cette condition sert à ouvrir le menu de l'utilisateur lorsque celui-ci appuie sur une touche */



     /*   if (OVRInput.GetDown(boutonFermeMenu, OVRInput.Controller.LTouch))
        {
            canvas.SetActive(false);

        }*/
        canvas.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + 1.5f);
        canvasBibli.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + 1.5f);
        canvasSousMenu.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + 1.5f);
        canvasClavier.transform.position = new Vector3(camera.transform.position.x, camera.transform.position.y, camera.transform.position.z + 1.6f);

    }

    public void menuReprendre()
    {
        canvas.SetActive(false);
        rightHand.GetComponent<ActiverDeplacement>().enabled = true;
        Time.timeScale = 1;
    }
    /* Cette fonction entre en jeu lorsque l'utilisateur appuie sur le bouton reprendre, il ferme l'affichage du menu */

    public void menuQuitter()
    {
        Application.Quit();
    }
    /* Cette fonction servira lors de la version finale de l'application (sans passer par unity) et permettra de quitter l'application */
    public void menuBibli()
    {
        canvas.SetActive(false);
        canvasBibli.SetActive(true);
    }
    /* Cette fonction entre en jeu lorsque l'utilisateur appuie sur le bouton biblitohèque, il ouvre un nouveau menu qui permettra après implémentation de regrouper les différents objets de l'environnemnt */

    public void bibliRetour()
    {
        canvasBibli.SetActive(false);
        canvas.SetActive(true);
    }
    /* Cette fonction entre en jeu lorsque l'utilisateur appuie sur le bouton retour une fois qu'il se trouve dans la bibliothèque, il le ramène au menu précédent */

    public void saveFct()
    {
        PlayerPrefs.SetString("scene", SceneManager.GetActiveScene().name);
        PlayerPrefs.SetFloat("x", player.transform.position.x);
        PlayerPrefs.SetFloat("y", player.transform.position.y);
        PlayerPrefs.SetFloat("z", player.transform.position.z);
        UnityEngine.Debug.Log("Sauvegarde effectuée");
    }

    public void RayCalcul()
    {
        if (leftHand.GetComponent<MesureRayCast>().enabled == false) 
        {
            leftHand.GetComponent<MesureRayCast>().enabled = true;
            cylinder.SetActive(true);
        } 
        else
        {
            leftHand.GetComponent<MesureRayCast>().enabled = false;
            cylinder.SetActive(false);
        }
    }

    public void SaveObject()
    {
        /*  if (leftHand.GetComponent<SaveObjet>().enabled == false)
          {
              leftHand.GetComponent<SaveObjet>().enabled = true;
              cylinder.SetActive(true);
          }
          else
          {
              leftHand.GetComponent<SaveObjet>().enabled = false;
              cylinder.SetActive(false);
          }
        */
        PlayerPrefs.GetString("ggez");
    }

    public void menuFonctions()
    {
        canvas.SetActive(false);
        canvasSousMenu.SetActive(true);
    }

    public void menuFonctionsRetour()
    {
        canvas.SetActive(true);
        canvasSousMenu.SetActive(false);
    }
}
