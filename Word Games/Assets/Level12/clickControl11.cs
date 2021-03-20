using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl11 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript11.currentWord += GetComponent<TextMesh>().text;
        gmScript11.letterNum += 1;
        gmScript11.selectletter[gmScript11.letterNum] = GetComponent<TextMesh>().text;    
    }
}
