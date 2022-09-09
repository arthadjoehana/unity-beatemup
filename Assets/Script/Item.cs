using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    int _numberOfDiskCollected;
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.name == "Player")
        {
            _numberOfDiskCollected++;
            Destroy(gameObject);
            Debug.Log("objet ramassé");
        }
        
    }
}
