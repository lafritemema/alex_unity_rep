using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class CubeTailleScript : MonoBehaviour
{
    
    public float Xnumber = 0.2f;
    public float Ynumber = 0.2f;
    public float Znumber = 0.2f;
  /*  public float Xpos;
    public float Zpos;
  */
    void Update()
    {
        transform.localScale = new Vector3 (Xnumber, Ynumber, Znumber);
      //  transform.position = new Vector3 (Xpos, 0, Zpos);

    }
    public void AdjustXnumber(float newXnumber)
    {
        Xnumber = newXnumber;
    }

    public void AdjustYnumber(float newYnumber)
    {
        Ynumber = newYnumber;
    }

    public void AdjustZnumber(float newZnumber)
    {
        Znumber = newZnumber;
    }

  /*  public void AdjustXpos(float newXpos)
    {
        Xpos = newXpos;
    }

    public void AdjustZpos(float newZpos)
    {
        Xpos = newZpos;
    }
  */
}
