using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class canvasScript : MonoBehaviour
{
    public GameObject canv;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= 5.00)
        {
            canv.SetActive(false);
        }
    }
}
