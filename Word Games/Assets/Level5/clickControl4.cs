using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl4 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript4.currentWord += GetComponent<TextMesh>().text;
        gmScript4.letterNum += 1;
        gmScript4.selectletter[gmScript4.letterNum] = GetComponent<TextMesh>().text;    
    }
}
