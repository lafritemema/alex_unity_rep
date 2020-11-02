/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PositionScript : MonoBehaviour
{

   public float Xnumber = 1.0f;
   public float Ynumber = 35.0f;
   public float Znumber = 6.0f;
   private Rigidbody rb;

   // Start is called before the first frame update
   void Start()
   {
       rb = GetComponent < Rigidbody>();
   }
 
  void FixedUpdate()
  {
     float moveHorizontal = Input.GetAxis("Horizontal");
      float moveVertical = Input.GetAxis("Vertical");

      Vector3 movement= new Vector3(moveHorizontal, 0.0f, moveVertical);

      rb.AddForce(movement * 5);
  }


// Update is called once per frame
void Update()
    {
        transform.position = new Vector3(Xnumber, Ynumber, Znumber);
    }
    public void AdjustXPos(float newXnumber)
    {
        Xnumber = newXnumber;
    }

    public void AdjustYPos(float newYnumber)
    {
        Ynumber = newYnumber;
    }

    public void AdjustZPos(float newZnumber)
    {
        Znumber = newZnumber;
    }



    /*   public void Modif()
       {
           aModifier.transform.position = new Vector3(Xnumber, Ynumber, Znumber);
       }
 
}
*/