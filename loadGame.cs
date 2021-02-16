using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadGame : MonoBehaviour
{
    public GameObject canvasXYZ;
    public GameObject canvasMenu;
    public GameObject xText;
    public GameObject zText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void load()
    {
        /*  if (PlayerPrefs.HasKey("scene"))
          {
              UnityEngine.Debug.Log("Chargement en cours");
              SceneManager.LoadScene(PlayerPrefs.GetString("scene"));
          }*/
        Application.LoadLevel("floorNwall");

    }

    public void testScene()
    {
        
        Application.LoadLevel("RightScene");

    }

    public void newGame()
    {
        canvasMenu.SetActive(false);
        canvasXYZ.SetActive(true);
    }

    public void X()
    {
        xText.SetActive(true);
        zText.SetActive(false);
    }

    public void Z()
    {
        xText.SetActive(false);
        zText.SetActive(true);
    }

    public void retour()
    {
        canvasMenu.SetActive(true);
        canvasXYZ.SetActive(false);
    }
}
