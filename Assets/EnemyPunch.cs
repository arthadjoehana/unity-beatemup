using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPunch : MonoBehaviour
{
    [SerializeField] int _MyDamage;

    [SerializeField] List<PlayerHealth> _savedCharacter;
    public bool ContainsCharacter()
    {
        if (_savedCharacter.Count > 0) return true;
        else return false;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.attachedRigidbody == null)
        {
            return;
        }
        var r = col.GetComponent<PlayerHealth>();
        if (r != null)
        {
            if (_savedCharacter.Contains(r))
            {

            }
            else
            {
                _savedCharacter.Add(r);
            }

        }

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        var r = col.GetComponent<PlayerHealth>();
        if (r != null)
        {
            if (_savedCharacter.Contains(r))
            {
                _savedCharacter.Remove(r);
            }
        }
    }
    public void ApplyDamage()
    {
        if (_savedCharacter != null)
        {
            foreach (PlayerHealth el in _savedCharacter)
            {
                el.Damage(_MyDamage);
            }
        }
    }
}
