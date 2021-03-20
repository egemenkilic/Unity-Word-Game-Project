using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl8 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript8.currentWord += GetComponent<TextMesh>().text;
        gmScript8.letterNum += 1;
        gmScript8.selectletter[gmScript8.letterNum] = GetComponent<TextMesh>().text;    
    }
}
