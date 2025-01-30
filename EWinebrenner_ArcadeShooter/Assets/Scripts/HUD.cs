using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;
    
    // Update is called once per frame
    void Update()
    {
        _scoreText.text = "Score: " + GameManager.Score.ToString();
    }
}
