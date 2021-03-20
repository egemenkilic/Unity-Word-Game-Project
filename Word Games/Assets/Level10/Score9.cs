using UnityEngine;
using UnityEngine.UI;

public class Score9: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript9.score.ToString("f0");
        scoreTextUI.text = gmScript9.score.ToString("f0");
    }
}
