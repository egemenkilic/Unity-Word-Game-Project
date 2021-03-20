﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gmScript4 : MonoBehaviour
{
    public static string currentWord;
    public Transform spelledWord;
    public string word = "ŞIK";
    public string word1 = "KIŞ";
    public static List<string> selectletter = new List<string>() { "", "", "", "", "", "", "", "" };
    public static int letterNum = 0;
    public Transform letter1;
    public Transform letter11;
    public Transform letter2;
    public Transform letter22;
    public Transform letter3;
    public Transform letter33;
    public Transform bottom1Obj;
    public Transform bottom2Obj;
    public Transform bottom3Obj;
    public static float score=0;
    public static float a=0;
    public static float highScore4;
    public GameObject pauseMenuUI;
    public static int loadLevel;
    public int random;
    int x = 0, y = 0;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        loadLevel = 5;
        PlayerPrefs.SetInt("loadLevel", loadLevel);
        bottom1Obj.GetComponent<TextMesh>().text = "K";
        bottom2Obj.GetComponent<TextMesh>().text = "Ş";
        bottom3Obj.GetComponent<TextMesh>().text = "I";
        highScore4 = PlayerPrefs.GetFloat("highScore4");
    }

    // Update is called once per frame
    public void Update()
    {
        a = 10000/(10 * Time.timeSinceLevelLoad);
        spelledWord.GetComponent<TextMesh>().text = currentWord;
        
        if (letter1.GetComponent<TextMesh>().text=="Ş" && letter2.GetComponent<TextMesh>().text=="I" && letter3.GetComponent<TextMesh>().text=="K" &&
            letter11.GetComponent<TextMesh>().text == "K" && letter22.GetComponent<TextMesh>().text == "I" && letter33.GetComponent<TextMesh>().text == "Ş")
        {       
            pauseMenuUI.SetActive(true);

            if (score > PlayerPrefs.GetFloat("highScore4"))
            {
                PlayerPrefs.SetString("name4", menu.namee);
                PlayerPrefs.SetFloat("highScore4", score);
                highScore4 = PlayerPrefs.GetFloat("highScore4");
            }
        }

    }

    public void Control() 
    {
        if (currentWord == word)
        {
            selectletter[1] = "Ş";
            selectletter[2] = "I";
            selectletter[3] = "K";
            letter1.GetComponent<TextMesh>().text = selectletter[1];
            letter2.GetComponent<TextMesh>().text = selectletter[2];
            letter3.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (currentWord == word1)
        {
            selectletter[1] = "K";
            selectletter[2] = "I";
            selectletter[3] = "Ş";
            letter11.GetComponent<TextMesh>().text = selectletter[1];
            letter22.GetComponent<TextMesh>().text = selectletter[2];
            letter33.GetComponent<TextMesh>().text = selectletter[3];
        }

        if (x == 0)
        {
            if (currentWord == word)
            {
                x = 1;
                score += a;
                a = 0;
            }
        }

        if (y == 0)
        {
            if (currentWord == word1)
            {
                y = 1;
                score += a;
                a = 0;
            }
        }
        else
            score -= 10;

        currentWord = "";
        selectletter[1] = "";
        selectletter[2] = "";
        selectletter[3] = "";
        selectletter[4] = "";
    }
    public void Left()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Right()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Switch()
    {
        random = Random.Range(0, 4);
        if (random == 3)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "I";
            bottom2Obj.GetComponent<TextMesh>().text = "Ş";
            bottom3Obj.GetComponent<TextMesh>().text = "K";
        }
        if (random == 2)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Ş";
            bottom2Obj.GetComponent<TextMesh>().text = "K";
            bottom3Obj.GetComponent<TextMesh>().text = "I";
        }
        if (random == 1)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "Ş";
            bottom2Obj.GetComponent<TextMesh>().text = "I";
            bottom3Obj.GetComponent<TextMesh>().text = "K";
        }
        if (random == 0)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "K";
            bottom2Obj.GetComponent<TextMesh>().text = "I";
            bottom3Obj.GetComponent<TextMesh>().text = "Ş";
        }
        if (random == 4)
        {
            bottom1Obj.GetComponent<TextMesh>().text = "K";
            bottom2Obj.GetComponent<TextMesh>().text = "Ş";
            bottom3Obj.GetComponent<TextMesh>().text = "I";
        }

    }
}