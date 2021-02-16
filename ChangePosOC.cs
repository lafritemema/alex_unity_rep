using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangePosOC : MonoBehaviour
{
    protected GameObject objetRecupere;
    public OVRInput.Button boutonValide;
    bool VraiFaux;
    float axisX;
    float axisZ;
   // private Rigidbody rb;
   private Vector3 tavu;
  //  protected OVRPlayerController playerController;
    RaycastHit hit;
    protected Vector3 objetPos;
    public GameObject elPlayer;
    // Start is called before the first frame update
    void Start()
    {
      //  rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(boutonValide, OVRInput.Controller.LTouch))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, 10))
            {
                objetRecupere = hit.collider.gameObject;
                 if (objetRecupere.layer == 8) 
                 {
                      objetRecupere = hit.collider.gameObject;
                      objetPos = objetRecupere.transform.position;

                    objetRecupere.transform.position = new Vector3(objetPos.x, 1, objetPos.z);                  /* Cette ligne permet de réhausser l'objet pour le mettre à 1 au dessus du sol afin de l'identifier. La ligne suivante désactive sa gravité afin qu'il ne tombe pas et celle d'après désactive sa rotation pour que le x et le z reste fixe et ainsi avoir un déplacement intuitif*/
                    objetRecupere.GetComponent<Rigidbody>().useGravity = false;
                    objetRecupere.GetComponent<Rigidbody>().freezeRotation = true;

                    VraiFaux = true;
                 // UnityEngine.Debug.Log("force rouge");
                 }
            }
        }
        if (OVRInput.GetDown(boutonValide, OVRInput.Controller.RTouch))
        {
            LocPos();
        }

            ChangementPosOC();
        axisX = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).x * 5;
        axisZ = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick).y * 5;
    }

  /*  void FixedUpdate()
    {

        tavu = new Vector3(objetPos.x + axisX, objetPos.y + 0.5f, objetPos.z + axisZ);
    }*/

    protected void ChangementPosOC()
    {
        if (VraiFaux == true)
        {
            objetRecupere.transform.Translate(axisX/100, 0, axisZ/100);
               elPlayer.GetComponent<CharacterController>().enabled = false;                        /* La ligne précédente permet la translation de l'objet. Les paramètres pris en compte agissent sur le déplacement du vecteur et non sur sa position (il permette le mouvement depuis la position actuelle). Cette ligne désactive les déplacements du joueur étant donné qu'il bouge l'objet avec le même joystick que celui pour se déplacer.)*/
             //  playerController.primaryAxis = 0;
          /*  rb.AddForce(tavu);
            elPlayer.GetComponent<CharacterController>().enabled = false;*/
        }
    }

    /* void OnTriggerEnter(Collider other)
     {
         if (other.gameObject.CompareTag("untagged"))
         {
             UnityEngine.Debug.Log("ALERTE SONMEZ !!!");
         } objetPos.y + 0.5f
     }*/

    protected void LocPos()
    {
        if (VraiFaux == true)
        {
            VraiFaux = false;
            elPlayer.GetComponent<CharacterController>().enabled = true;                    /*Le premier réactive les déplacements du joueur, le second la gravité sur l'objet sélectionné*/
            objetRecupere.GetComponent<Rigidbody>().useGravity = true;


        }
    }
}



/*
 *  if (OVRInput.GetDown(boutonValide, OVRInput.Controller.LTouch))
        { if (VraiFaux == true)
            {
                VraiFaux = false;
            } 
        }
 */
