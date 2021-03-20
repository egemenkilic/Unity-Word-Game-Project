using UnityEngine;
using UnityEngine.UI;

public class Score1 : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript1.score.ToString("f0");
        scoreTextUI.text = gmScript1.score.ToString("f0");
    }
}
