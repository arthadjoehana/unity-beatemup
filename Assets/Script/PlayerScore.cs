using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerScore : MonoBehaviour
{
    public int NumberOfItems { get; private set; }

    public UnityEvent<PlayerScore> OnItemCollected;

    public void ItemCollected()
    {
        NumberOfItems++;
        OnItemCollected.Invoke(this);
    }
}
