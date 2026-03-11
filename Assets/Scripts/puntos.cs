

using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;


    public TextMeshProUGUI scoreText;


    private int score = 0;


    void Awake()
    {
        Instance = this;
    }


    public void AddPoints(int amount)
    {
        score += amount;
        scoreText.text = "Puntos: " + score;
    }
}
