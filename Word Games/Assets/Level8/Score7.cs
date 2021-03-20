using UnityEngine;
using UnityEngine.UI;

public class Score7: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript7.score.ToString("f0");
        scoreTextUI.text = gmScript7.score.ToString("f0");
    }
}
