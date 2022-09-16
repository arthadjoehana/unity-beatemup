using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PlayerRef")]
public class PlayerReference : ScriptableObject
{
    PlayerScore _playerScore;
    PlayerHealth _playerHealth;

    public PlayerScore PlayerScore { get => _playerScore; set => _playerScore = value; }
    public PlayerHealth PlayerHealth { get => _playerHealth; set => _playerHealth = value; }

}
