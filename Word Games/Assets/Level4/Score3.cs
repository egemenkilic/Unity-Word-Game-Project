using UnityEngine;
using UnityEngine.UI;

public class Score3 : MonoBehaviour
{
    public Text scoreText;
    public Text scoreTextUI;
    void Update()
    {
        scoreText.text = gmScript3.score.ToString("f0");
        scoreTextUI.text = gmScript3.score.ToString("f0");
    }
}
