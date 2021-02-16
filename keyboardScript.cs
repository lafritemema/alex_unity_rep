using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;    


public class keyboardScript : MonoBehaviour
{
    private const string SAVE_SEPARATOR = "#SAVE-VALUE#";
    string texteComplet;
    public Text changement;
    public static float x;
    public static float z;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void A()
    {
        texteComplet += "a";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void B()
    {
        texteComplet += "b";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void C()
    {
        texteComplet += "c";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void D()
    {
        texteComplet += "d";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void E()
    {
        texteComplet += "e";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void F()
    {
        texteComplet += "f";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void G()
    {
        texteComplet += "g";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void H()
    {
        texteComplet += "h";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void I()
    {
        texteComplet += "i";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void J()
    {
        texteComplet += "j";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void K()
    {
        texteComplet += "k";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void L()
    {
        texteComplet += "l";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void M()
    {
        texteComplet += "m";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void N()
    {
        texteComplet += "n";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void O()
    {
        texteComplet += "o";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void P()
    {
        texteComplet += "p";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void Q()
    {
        texteComplet += "q";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void R()
    {
        texteComplet += "r";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void S()
    {
        texteComplet += "s";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void T()
    {
        texteComplet += "t";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void U()
    {
        texteComplet += "u";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void V()
    {
        texteComplet += "v";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void W()
    {
        texteComplet += "w";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void X()
    {
        texteComplet += "x";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void Y()
    {
        texteComplet += "y";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void Z()
    {
        texteComplet += "z";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void UN()
    {
        texteComplet += "1";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void DEUX()
    {
        texteComplet += "2";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void TROIS()
    {
        texteComplet += "3";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void QUATRE()
    {
        texteComplet += "4";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void CINQ()
    {
        texteComplet += "5";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void SIX()
    {
        texteComplet += "6";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void SEPT()
    {
        texteComplet += "7";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void HUIT()
    {
        texteComplet += "8";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void NEUF()
    {
        texteComplet += "9";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void ZERO()
    {
        texteComplet += "0";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void SPACEBAR()
    {
        texteComplet += " ";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void POINT()
    {
        texteComplet += ".";
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void DELETE()
    {
        texteComplet = texteComplet.Remove(texteComplet.Length - 1);
        changement.GetComponent<Text>().text = texteComplet;
    }

    public void ENTERX()
    {
        PlayerPrefs.SetString("x", texteComplet);
    }

    public void ENTERZ()
    {
        PlayerPrefs.SetString("z", texteComplet);
    }












    public void GpadidX()
    {

        /*      SaveObject sonmsonm = new SaveObject
              {
                  x = float.Parse(texteComplet),
                  z = 2f
              };




                  string nomdevariableultrastyle = JsonUtility.ToJson(sonmsonm);
                  UnityEngine.Debug.Log(nomdevariableultrastyle);
                  File.WriteAllText(Application.dataPath + "/streamingAssets/jsontest.json", nomdevariableultrastyle);

                  /* SaveObject charge = JsonUtility.FromJson<SaveObject>(nomdevariableultrastyle);
                   UnityEngine.Debug.Log(charge.sonmez);*/
        x = float.Parse(texteComplet); 
        UnityEngine.Debug.Log("KeyboardKeyboardKeyboard X= " + x);
       
    }

    public void GpadidZ()
    {
       /* 
                SaveObject sonmsonm = new SaveObject
                {
                    x = 2f,
                    z = float.Parse(texteComplet),
                };

                string nomdevariableultrastyle = JsonUtility.ToJson(sonmsonm);
                UnityEngine.Debug.Log(nomdevariableultrastyle);
                File.WriteAllText(Application.dataPath + "/streamingAssets/jsontest.json", nomdevariableultrastyle);

        /* SaveObject charge = JsonUtility.FromJson<SaveObject>(nomdevariableultrastyle);
         UnityEngine.Debug.Log(charge.sonmez);*/
        z = float.Parse(texteComplet); 
        UnityEngine.Debug.Log("KeyboardKeyboardKeyboard Z= " + z);
        
    }

  /*  public class SaveObject
    {
        public float x;
        public float z;

    }
    */
}
