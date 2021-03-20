using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl12 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript12.currentWord += GetComponent<TextMesh>().text;
        gmScript12.letterNum += 1;
        gmScript12.selectletter[gmScript12.letterNum] = GetComponent<TextMesh>().text;    
    }
}
