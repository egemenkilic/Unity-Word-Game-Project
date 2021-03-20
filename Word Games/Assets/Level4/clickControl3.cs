using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl3 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript3.currentWord += GetComponent<TextMesh>().text;
        gmScript3.letterNum += 1;
        gmScript3.selectletter[gmScript3.letterNum] = GetComponent<TextMesh>().text;    
    }
}
