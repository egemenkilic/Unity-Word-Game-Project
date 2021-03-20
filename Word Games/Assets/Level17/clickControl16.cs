using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl16 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript16.currentWord += GetComponent<TextMesh>().text;
        gmScript16.letterNum += 1;
        gmScript16.selectletter[gmScript16.letterNum] = GetComponent<TextMesh>().text;    
    }
}
