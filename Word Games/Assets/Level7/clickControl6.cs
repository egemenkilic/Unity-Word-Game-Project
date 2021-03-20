using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl6 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript6.currentWord += GetComponent<TextMesh>().text;
        gmScript6.letterNum += 1;
        gmScript6.selectletter[gmScript6.letterNum] = GetComponent<TextMesh>().text;    
    }
}
