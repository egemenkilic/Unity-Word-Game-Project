using UnityEngine;
using UnityEngine.UI;

public class Score11: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript11.score.ToString("f0");
        scoreTextUI.text = gmScript11.score.ToString("f0");
    }
}
