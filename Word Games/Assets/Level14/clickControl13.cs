using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl13 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript13.currentWord += GetComponent<TextMesh>().text;
        gmScript13.letterNum += 1;
        gmScript13.selectletter[gmScript13.letterNum] = GetComponent<TextMesh>().text;    
    }
}
