using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private int _numberOfDiskCollected;
    private int _playerScore;


    private void Start()
    {
        _numberOfDiskCollected = 0;
        Debug.Log(_numberOfDiskCollected);
        _playerScore = 0;
    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.attachedRigidbody.gameObject.name == "Player")
        {
            _numberOfDiskCollected++;
            _playerScore += 100;
            Destroy(gameObject);
            Debug.Log("objet ramassé");
        }
        
    {
        
    }
    }
}
