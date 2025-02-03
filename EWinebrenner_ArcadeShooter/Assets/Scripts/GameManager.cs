using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager
{
    //public delegate void ScoreChangedHandler(int score);
    public static event Action<int> ScoreChanged;

    private static int _score;
    public static int Score
    {
        get
        {
            return _score;
        }
        set
        {
            //If the value hasnt changed, return early
            if (_score == value)
                return;

            _score = value;
            _score = Mathf.Max(_score, 0);
            //Send out an event saying that the score changed
            ScoreChanged?.Invoke(_score);
        }
    }


    public static event Action<float, float> HealthChanged;

    private static float _health;
    public static float Health
    {
        get
        {
            return _health;
        }
        set
        {
            //If the value hasnt changed, return early
            if (_health == value)
                return;

            float prevHealth = _health;
            _health = value;
            _health = Mathf.Max(_health, 0);
            //Send out an event saying that the score changed
            HealthChanged?.Invoke(_health,prevHealth);
        }
    }
    //public static void SetScore(int score)
    //{
    //    _score = score;
    //}
    //public static int GetScore()
    //{
    //    return _score;
    //}
}
