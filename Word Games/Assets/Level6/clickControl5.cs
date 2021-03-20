using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl5 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript5.currentWord += GetComponent<TextMesh>().text;
        gmScript5.letterNum += 1;
        gmScript5.selectletter[gmScript5.letterNum] = GetComponent<TextMesh>().text;    
    }
}
