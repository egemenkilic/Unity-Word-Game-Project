using UnityEngine;
using UnityEngine.UI;

public class Score5: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript5.score.ToString("f0");
        scoreTextUI.text = gmScript5.score.ToString("f0");
    }
}
