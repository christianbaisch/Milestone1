using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Globalization;

public class Utilities : MonoBehaviour
{
    public static string ProcessText(string textIn)
    {
        try
        {
            float result = float.Parse(textIn);
            textIn = "Number";
        }
        catch (FormatException)
        {
            textIn = "String";
        }
        return textIn;
        //return the word "string" if the user enters string
        //return number if number inclues decimals
    }

    public static string AverageChar(string textIn)
    {
        
        float myLength = 0;
    
        string[] words = textIn.Split(' ');
        
        
        foreach(string word in words)
        {
           myLength = myLength + word.Length;
        }
        myLength = myLength / words.Length;

        textIn = myLength.ToString();
        return textIn;

    }

    static public Material[] GetAllMaterials(GameObject go){
        Renderer[] rends = go.GetComponentsInChildren<Renderer>();

        List<Material> mats = new List<Material>();
        foreach (Renderer rend in rends){
            mats.Add( rend.material);
        }

        return ( mats.ToArray() );
    }
    
}