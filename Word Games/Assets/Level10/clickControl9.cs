using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl9 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript9.currentWord += GetComponent<TextMesh>().text;
        gmScript9.letterNum += 1;
        gmScript9.selectletter[gmScript9.letterNum] = GetComponent<TextMesh>().text;    
    }
}
