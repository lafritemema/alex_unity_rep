using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class GoNextScript : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
    public GameObject floor;
   // public Transform Joueur;
    // Start is called before the first frame update
    void Start()
    {
        ovrGrabbable = GetComponent<OVRGrabbable>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ovrGrabbable.isGrabbed)
        {
            //GameObject.FindWithTag("player").transform.localPosition = new Vector3(2, 67, 1);
           // GameObject.FindWithTag("player").transform.position = new Vector3(1, Joueur.transform.position.y, Joueur.transform.position.z);
            floor.SetActive(false);
        }


    }
}
