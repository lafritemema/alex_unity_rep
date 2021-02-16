using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class floorNwall : MonoBehaviour
{
    public GameObject plane;
    protected float Xnumber;
    protected float Znumber;
    // Start is called before the first frame update
    void Start()
    {
      /*  if (File.Exists(Application.dataPath + "/streamingAssets/jsontest.json"))
        {
            string readingstring = File.ReadAllText(Application.dataPath + "/streamingAssets/jsontest.json");
            keyboardScript.SaveObject sonmIIsonmII = JsonUtility.FromJson<keyboardScript.SaveObject>(readingstring);

             UnityEngine.Debug.Log("Test sonmIIsonmII");
             UnityEngine.Debug.Log(sonmIIsonmII.x);
             UnityEngine.Debug.Log(sonmIIsonmII.z);

            Xnumber = float.Parse(sonmIIsonmII.x);
              Znumber = float.Parse(sonmIIsonmII.z);


              UnityEngine.Debug.Log("Test sonmIIsonmII apres le parsing");
              UnityEngine.Debug.Log(Xnumber);
              UnityEngine.Debug.Log(Znumber);
            
             Xnumber = sonmIIsonmII.x;
             Znumber = sonmIIsonmII.z;
            
            
        }*/
        UnityEngine.Debug.Log("floorNwall X=" + keyboardScript.x);
        UnityEngine.Debug.Log("floorNwall Z=" + keyboardScript.z);
        Xnumber = keyboardScript.x;
        Znumber = keyboardScript.z;

        plane.transform.localScale = new Vector3(Xnumber, 1, Znumber);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
