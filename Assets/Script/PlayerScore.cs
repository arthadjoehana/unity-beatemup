using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScore : MonoBehaviour
{
    [SerializeField] PlayerReference playerReference;
    [SerializeField] ScoreUI scoreUI;

    int _playerScore;
    public int Score { get => _playerScore; }

    public void Start()
    {
        playerReference.PlayerScore = this;
        _playerScore = 0;
    }

    public void ResetScore()
    {
        _playerScore = 0;
    }
    public void AddScore(int score)
    {
        if (score < 0) return;

        _playerScore += score;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreUI.UpdateScoreText(this);
    }


}
