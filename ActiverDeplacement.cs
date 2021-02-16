using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiverDeplacement : MonoBehaviour
{
    public GameObject leftHand;
    public OVRInput.Button boutonValide;
    public GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(boutonValide, OVRInput.Controller.RTouch))
        {
            if (leftHand.GetComponent<ChangePosOC>().enabled == false)
            { 
                leftHand.GetComponent<ChangePosOC>().enabled = true;
                cylinder.SetActive(true);

            } else
            {
                leftHand.GetComponent<ChangePosOC>().enabled = false;
                cylinder.SetActive(false);
            }
        }

    }
}
