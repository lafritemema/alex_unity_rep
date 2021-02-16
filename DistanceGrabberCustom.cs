using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
#if UNITY_EDITOR
using UnityEngine.SceneManagement;
#endif



/*
namespace DistanceGrabberCustom
{
    

}
*/
/// <summary>
/// Allows grabbing and throwing of objects with the DistanceGrabbable component on them.
/// </summary>
[RequireComponent(typeof(Rigidbody))]
public class DistanceGrabberCustom : DistanceGrabber
{

    protected Vector3 vec;

    public float ObjectPullVelocity
    {
        get { return base.m_objectPullVelocity; }
        set
        {
            base.m_objectPullVelocity = value;
        }
    }
    /*Fonction get-set de l'objectPullVelocity venant de la super class distanceGrabber */

    public bool MoveToHand
    {
        get { return base.m_movingObjectToHand; }
        set
        {
            base.m_movingObjectToHand = value;
        }
    }
    /*Fonction get-set du movingObjectToHand venant de la super class distanceGrabber */
    public OVRGrabbable grabbedObj
    {
        get { return base.m_grabbedObj; }
    }
    /*Fonction get de m_grabbedObj,  renvoyant true lorsqu'aucun objet n'est attrapé, venant de la super class distanceGrabber */
    public bool isgrabbedObj
    {
        get { return base.m_grabbedObj != null; }
    }
    /*Fonction get de m_grabbedObj, renvoyant true lorsqu'un objet est attrapé, venant de la super class distanceGrabber */
    /*  public void InfoPos()
      {
          UnityEngine.Debug.Log(transform.localPosition.x);
          UnityEngine.Debug.Log(transform.localPosition.y);
          UnityEngine.Debug.Log(transform.localPosition.z);
      }

      protected override void Awake()
      {
          base.Awake();
          vec = new Vector3 (0, 0, transform.localPosition.z);
          m_anchorOffsetPosition = nvm;

      }
      protected override void OnUpdatedAnchors()
      {
          base.OnUpdatedAnchors();

      }*/
}