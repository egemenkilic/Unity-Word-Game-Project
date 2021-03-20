using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl1 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript1.currentWord += GetComponent<TextMesh>().text;
        gmScript1.letterNum += 1;
        gmScript1.selectletter[gmScript1.letterNum] = GetComponent<TextMesh>().text;    
    }
}
