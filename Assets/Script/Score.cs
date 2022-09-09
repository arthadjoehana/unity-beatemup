using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private TextMeshProUGUI itemText;

    void Start()
    {
        itemText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateItemText(PlayerScore playerScore)
    {
        itemText.text = playerScore.NumberOfItems.ToString();
    }
}
