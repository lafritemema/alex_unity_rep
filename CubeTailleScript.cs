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
        /*Cette ligne sert à changer le scale en x, y et z du cube désigné à l'aide des fonctions à la suite du programme*/

      //  transform.position = new Vector3 (Xpos, 0, Zpos);

    }
    public void AdjustXnumber(float newXnumber)
    {
        Xnumber = newXnumber;
    }
    /*Cette fonction permet de changer la valeur de Xnumber
     Elle prend en paramètre newXnumber qui est, dans l'application, la valeur que l'utilisateur donne au curseur X
     */
    public void AdjustYnumber(float newYnumber)
    {
        Ynumber = newYnumber;
    }
    /*Cette fonction permet de changer la valeur de Ynumber
   Elle prend en paramètre newYnumber qui est, dans l'application, la valeur que l'utilisateur donne au curseur Y
   */
    public void AdjustZnumber(float newZnumber)
    {
        Znumber = newZnumber;
    }
    /*Cette fonction permet de changer la valeur de Znumber
  Elle prend en paramètre newZnumber qui est, dans l'application, la valeur que l'utilisateur donne au curseur Z
  */


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
