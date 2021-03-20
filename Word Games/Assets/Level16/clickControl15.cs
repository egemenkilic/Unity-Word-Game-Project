using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl15 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript15.currentWord += GetComponent<TextMesh>().text;
        gmScript15.letterNum += 1;
        gmScript15.selectletter[gmScript15.letterNum] = GetComponent<TextMesh>().text;    
    }
}
