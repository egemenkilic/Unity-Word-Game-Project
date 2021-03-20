using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript.currentWord += GetComponent<TextMesh>().text;
        gmScript.letterNum += 1;
        gmScript.selectletter[gmScript.letterNum] = GetComponent<TextMesh>().text;    
    }
}
