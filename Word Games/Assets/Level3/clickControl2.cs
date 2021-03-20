using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl2 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript2.currentWord += GetComponent<TextMesh>().text;
        gmScript2.letterNum += 1;
        gmScript2.selectletter[gmScript2.letterNum] = GetComponent<TextMesh>().text;    
    }
}
