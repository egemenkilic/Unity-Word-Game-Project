using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickControl7 : MonoBehaviour
{
    private void OnMouseDown()
    {   
        gmScript7.currentWord += GetComponent<TextMesh>().text;
        gmScript7.letterNum += 1;
        gmScript7.selectletter[gmScript7.letterNum] = GetComponent<TextMesh>().text;    
    }
}
