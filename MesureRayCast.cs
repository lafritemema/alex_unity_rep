using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MesureRayCast : MonoBehaviour
{
    public OVRInput.Button boutonCalculA;
    public OVRInput.Button boutonCalculB;
    protected List<Vector3> deuxObjets = new List<Vector3>();
    protected GameObject cible;
    private Vector3 positionA;
    RaycastHit hit;
    RaycastHit hitDeuxPointZero;
    public Text changement;


    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {

        Debug.DrawRay(transform.position, transform.forward * 10, Color.blue);
    //    Debug.DrawRay(positionA, transform.forward * 10, Color.green);

        if (OVRInput.GetDown(boutonCalculA, OVRInput.Controller.LTouch))
        {
            listObjetsGauche();
            UnityEngine.Debug.Log(Vector3.Distance(deuxObjets[0], deuxObjets[1]));
            changement.GetComponent<Text>().text = Vector3.Distance(deuxObjets[0], deuxObjets[1]).ToString();

        }
        if (OVRInput.GetDown(boutonCalculB, OVRInput.Controller.RTouch))
        {
            listObjetsDroite();
            UnityEngine.Debug.Log(Vector3.Distance(deuxObjets[0], deuxObjets[1]));
            changement.GetComponent<Text>().text = Vector3.Distance(deuxObjets[0], deuxObjets[1]).ToString();

        }

        /* if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
          {
              cible = hit.collider.gameObject;
              positionA = cible.transform.position; //hit.point;
              //UnityEngine.Debug.Log(positionA);
              UnityEngine.Debug.Log(Vector3.Distance(positionA, sonmez.transform.position));
          }


     }
     if (OVRInput.GetDown(boutonCalculB, OVRInput.Controller.RTouch))
     {
         if (Physics.Raycast(positionA, cible.transform.forward, out hitDeuxPointZero, 10))
         {

             UnityEngine.Debug.Log(hitDeuxPointZero.distance);


         }  */

    }

        public void listObjetsGauche()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
        {
            // deuxObjets[0] = hit.collider.gameObject;
            deuxObjets.Add(hit.point);
            deuxObjets[0] = hit.point;
           // UnityEngine.Debug.Log(deuxObjets[0]);
        }
    }

    public void listObjetsDroite()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hitDeuxPointZero, 10))
        {
           //  deuxObjets[1] = hit.collider.gameObject;
             deuxObjets.Add(hitDeuxPointZero.point);
            deuxObjets[1] = hitDeuxPointZero.point;
           // UnityEngine.Debug.Log(deuxObjets[1]);
        }
    }
}
