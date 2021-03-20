using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl17 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript17.currentWord += GetComponent<TextMesh>().text;
        gmScript17.letterNum += 1;
        gmScript17.selectletter[gmScript17.letterNum] = GetComponent<TextMesh>().text;    
    }
}
