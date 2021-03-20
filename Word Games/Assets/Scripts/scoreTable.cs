using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTable : MonoBehaviour
{
    public Text text;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public Text text6;
    public Text text7;
    public Text text8;
    public Text text9;
    public Text text10;
    public Text text11;
    public Text text12;
    public Text text13;
    public Text text14;
    public Text text15;
    public Text text16;
    public Text text17;

    public Text name;
    public Text name1;
    public Text name2;
    public Text name3;
    public Text name4;
    public Text name5;
    public Text name6;
    public Text name7;
    public Text name8;
    public Text name9;
    public Text name10;
    public Text name11;
    public Text name12;
    public Text name13;
    public Text name14;
    public Text name15;
    public Text name16;
    public Text name17;

    
    public void Show()
    {
        name.text = PlayerPrefs.GetString("name");
        name1.text = PlayerPrefs.GetString("name1");
        name2.text = PlayerPrefs.GetString("name2");
        name3.text = PlayerPrefs.GetString("name3");
        name4.text = PlayerPrefs.GetString("name4");
        name5.text = PlayerPrefs.GetString("name5");
        name6.text = PlayerPrefs.GetString("name6");
        name7.text = PlayerPrefs.GetString("name7");
        name8.text = PlayerPrefs.GetString("name8");
        name9.text = PlayerPrefs.GetString("name9");
        name10.text = PlayerPrefs.GetString("name10");
        name11.text = PlayerPrefs.GetString("name11");
        name12.text = PlayerPrefs.GetString("name12");
        name13.text = PlayerPrefs.GetString("name13");
        name14.text = PlayerPrefs.GetString("name14");
        name15.text = PlayerPrefs.GetString("name15");
        name16.text = PlayerPrefs.GetString("name16");
        name17.text = PlayerPrefs.GetString("name17");


        text.text = PlayerPrefs.GetFloat("highScore").ToString("f0");
        text1.text = PlayerPrefs.GetFloat("highScore1").ToString("f0");
        text2.text = PlayerPrefs.GetFloat("highScore2").ToString("f0");
        text3.text = PlayerPrefs.GetFloat("highScore3").ToString("f0");
        text4.text = PlayerPrefs.GetFloat("highScore4").ToString("f0");
        text5.text = PlayerPrefs.GetFloat("highScore5").ToString("f0");
        text6.text = PlayerPrefs.GetFloat("highScore6").ToString("f0");
        text7.text = PlayerPrefs.GetFloat("highScore7").ToString("f0");
        text8.text = PlayerPrefs.GetFloat("highScore8").ToString("f0");
        text9.text = PlayerPrefs.GetFloat("highScore9").ToString("f0");
        text10.text = PlayerPrefs.GetFloat("highScore10").ToString("f0");
        text11.text = PlayerPrefs.GetFloat("highScore11").ToString("f0");
        text12.text = PlayerPrefs.GetFloat("highScore12").ToString("f0");
        text13.text = PlayerPrefs.GetFloat("highScore13").ToString("f0");
        text14.text = PlayerPrefs.GetFloat("highScore14").ToString("f0");
        text15.text = PlayerPrefs.GetFloat("highScore15").ToString("f0");
        text16.text = PlayerPrefs.GetFloat("highScore16").ToString("f0");
        text17.text = PlayerPrefs.GetFloat("highScore17").ToString("f0");
    }
}
