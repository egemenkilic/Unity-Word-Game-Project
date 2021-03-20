using UnityEngine;
using UnityEngine.UI;

public class Score6: MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript6.score.ToString("f0");
        scoreTextUI.text = gmScript6.score.ToString("f0");
    }
}
