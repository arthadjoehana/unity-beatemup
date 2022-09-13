using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    [SerializeField] PlayerReference playerReference;
    
    [SerializeField] int _diskValue;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.attachedRigidbody == null) return;
        
        if (other.attachedRigidbody.gameObject.name == "Player")
        {
            playerReference.PlayerScore.AddScore(_diskValue);
            gameObject.SetActive(false);
            //Destroy(gameObject);
        }
    }

    
}
