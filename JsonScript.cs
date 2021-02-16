using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JsonScript : MonoBehaviour
{
    string chemin;
    string jsonString;
    public List<GameObject> listObjets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // chemin = Application.streamingAssetsPath + "/map.json";
        chemin = Application.streamingAssetsPath + "/newGame.json";
        jsonString = File.ReadAllText(chemin);
       // UnityEngine.Debug.Log(jsonString);
        Map map = JsonUtility.FromJson<Map>(jsonString);
        UnityEngine.Debug.Log(map.MapName);
    }

   public class Map
    {
        public string MapName;
    }

    public class JsonObjects
    {
      
    }
}
/*
 * map.MapName = "Sonmez";
 * jsonString = JsonUtility.ToJson(map);
 * File.WriteAllText(chemin, jsonString);
 */