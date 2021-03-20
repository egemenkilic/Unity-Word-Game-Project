using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl10 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript10.currentWord += GetComponent<TextMesh>().text;
        gmScript10.letterNum += 1;
        gmScript10.selectletter[gmScript10.letterNum] = GetComponent<TextMesh>().text;    
    }
}
