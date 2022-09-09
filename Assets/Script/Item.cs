using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private int _numberOfDiskCollected;

    private void Start()
    {
        _numberOfDiskCollected = 0;
        Debug.Log(_numberOfDiskCollected);

    }
    private void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.attachedRigidbody.gameObject.name == "Player")
        {
            _numberOfDiskCollected++;
            Destroy(gameObject);
            Debug.Log("objet ramassé");
        }
        
    {
        
    }
    }
}
