using UnityEngine;
using UnityEngine.UI;

public class Score15: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript15.score.ToString("f0");
        scoreTextUI.text = gmScript15.score.ToString("f0");
    }
}
