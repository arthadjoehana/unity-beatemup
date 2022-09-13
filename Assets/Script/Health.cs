using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] int _hp;
    [SerializeField] UnityEvent _onDamage;
    [SerializeField] Animator _animator;
    [SerializeField] GameObject _drop;


    // Start is called before the first frame update
    bool _isDead;
    int currenthp;
    int _numberOfDrop;

    private void Start()
    {
        _isDead = false;
        currenthp = _hp;
        _numberOfDrop = 0;
    }
    
    public void Damage(int amount)
    {
        currenthp = currenthp - amount;
        Debug.Log(currenthp);
        if (_animator != null)
        {
            _animator.SetTrigger("Hit");
        }


        if (currenthp <= 0)
        {
            _isDead = true;
            
            Debug.Log(currenthp);
            if (_animator != null)
            {
                _animator.SetTrigger("Death");

            }
            if (_animator == null)
            {
                Destroy(gameObject);
                
            }
            if (_numberOfDrop == 0)
            dropDisk();
            _numberOfDrop++;
        }
    }

    public void dropDisk()
    {
        if (_isDead)
        {
            Instantiate(_drop, transform.position, transform.rotation);
        }
    }
}