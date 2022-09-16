using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour
{
    [SerializeField] PlayerReference playerReference;
    
    [SerializeField] int _diskValue;

    bool _available;

    void Start()
    {
        _available = false;
        StartCoroutine(drop());
        
    }
    IEnumerator drop()
    {
        yield return new WaitForSeconds(1f);
        _available = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_available)
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

    
}
