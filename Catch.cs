using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;

public class Catch : MonoBehaviour
{
    private OVRGrabbable ovrGrabbable;
  //  public OVRInput.Button button;
    // public DistanceGrabber distanceGrabber;
    protected DistanceGrabberCustom grab;
    protected float firstYObject;
   // protected Vector3 grabbedObject;
    private float pullVelo;
    private Vector3 rHand;
    // public GameObject game;
    //public Rigidbody rb;

    // Start is called before the first frame update


    void Start()
    {
        
        grab = GetComponent<DistanceGrabberCustom>();
        firstYObject = grab.grabbedObj.transform.position.y;
      //  grabbedObject = grab.grabbedObj.transform.position;


    }

    // Update is called once per frame
    void Update()
    {
  
        pullVelo = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick).y * -10;
        rHand = GameObject.FindGameObjectWithTag("RHand").transform.position;
      //  UnityEngine.Debug.Log(rHand.x+0.5f);

        if (grab.isgrabbedObj)
        {
            grab.ObjectPullVelocity = 10;
            ovrGrabbable = grab.grabbedObj;
            // UnityEngine.Debug.Log(grab.grabbedObj);
            //   grab.grabbedObj.transform.position = new Vector3(grab.grabbedObj.transform.position.x, firstYObject +1 , grab.grabbedObj.transform.position.z);
            // grabbedObject = new Vector3(grabbedObject.x, grabbedObject.y +1 , grabbedObject.z);
            grab.grabbedObj.transform.position = new Vector3(rHand.x, firstYObject + 1, rHand.z + pullVelo);

        }
        /*Cette condition permet de changer la velocité à laquelle arrive l'objet attrapé */

    }


    /*L'ensembe de cette fonction est difficile à doccumenter, la plupart de ces fonctions/paramètres sont amenés à changer. Je travaille en ce moment dessus et j'ai plusieurs tests à y effectuer. */

}
/*   
    
       void Start() {}
       rb = GetComponent<Rigidbody>();
        distanceGrabber = GetComponent<DistanceGrabber>();
        ovrGrabbable = GetComponent<OVRGrabbable>();
        
        UnityEngine.Debug.Log(grab.ObjectPullVelocity);
        grab.ObjectPullVelocity = 0.0f;

        UnityEngine.Debug.Log(grab.ObjectPullVelocity);




    void Update(){}
    rb.velocity = Vector3.zero;
  rb.angularVelocity = Vector3.zero;

 
      UnityEngine.Debug.Log(ovrGrabbable.grabbedBy.GetController());

        UnityEngine.Debug.Log(distanceGrabber.ObjectPullVelocity);
          distanceGrabber.changeVelocity();
        if (OVRInput.Get(OVRInput.Button.One) == true) { 
            UnityEngine.Debug.Log(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y);
            UnityEngine.Debug.Log(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x);
            UnityEngine.Debug.Log(OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick));
            UnityEngine.Debug.Log(sonmez);

        } 
 
 if (OVRInput.GetDown(button, ovrGrabbable.grabbedBy.GetController())) //(ovrGrabbable.isGrabbed && OVRInput.GetDown(shootingButton,ovrGrabbable.grabbedBy.GetController())
            {
                UnityEngine.Debug.Log(sonmez);
                grab.ObjectPullVelocity = sonmez;
}
 */
