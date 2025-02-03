using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    private void OnEnable()
    {
        GameManager.ScoreChanged += GameManager_ScoreChanged;
        GameManager.HealthChanged += GameManager_HealthChanged;
    }

    private void OnDisable()
    {
        GameManager.ScoreChanged -= GameManager_ScoreChanged;
        GameManager.HealthChanged -= GameManager_HealthChanged;
    }

    private void GameManager_HealthChanged(float health, float prevHealth)
    {
        throw new System.NotImplementedException();
    }

    private void GameManager_ScoreChanged(int score)
    {
        //Debug.Log("Score changed");
        _scoreText.text = "Score: " + score.ToString();
    }
}
