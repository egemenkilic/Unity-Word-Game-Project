using UnityEngine;
using UnityEngine.UI;

public class Score14: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript14.score.ToString("f0");
        scoreTextUI.text = gmScript14.score.ToString("f0");
    }
}
