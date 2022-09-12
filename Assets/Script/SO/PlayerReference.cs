using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="PlayerRef")]
public class PlayerReference : ScriptableObject
{
    PlayerScore _playerScore;

    public PlayerScore PlayerScore { get => _playerScore; set => _playerScore = value; }

    

}
