using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl14 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript14.currentWord += GetComponent<TextMesh>().text;
        gmScript14.letterNum += 1;
        gmScript14.selectletter[gmScript14.letterNum] = GetComponent<TextMesh>().text;    
    }
}
