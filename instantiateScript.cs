using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Net;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class instantiateScript : MonoBehaviour
{
    public List<GameObject> mesObjets = new List<GameObject>();
    public GameObject monCube;
    public GameObject prefabCube;
    private GameObject Instance;
    public Text listText;
    public int sonmez;

    // public GameObject naviguation;

    // Start is called before the first frame update
    void start()
    {
    }
public void cube()
    {
        
        Instance = Instantiate(monCube);
        mesObjets.Add(Instance);
        listText.text = mesObjets.ToString();

    }
    /* Cette fonction sert à instancier un gameobject passer en paramètre. Tout les gamesObject ainsi créer sont ajoutés directement à une liste     */
    void update()
    {

    }

    public List<GameObject> getList()
    {
        return mesObjets;
    }

    public void Sonmez()
    {
        sonmez = mesObjets.Count-1;
        Instantiate(mesObjets[sonmez]);
    }
    /*Cette fonction sert à récupérer la liste de gameObject instancier*/

   /* public void instanceTest()
    {
        Instance = Instantiate(prefabCube);
    }
   */
    /* void OnCollisionEnter(Collision other)
     {
         if (other.gameObject == true) { 
         UnityEngine.Debug.Log("collision");

     new Vector3(10.0f, 0.0f, -10.0f), Quaternion.identity
         }
     }*/


}
