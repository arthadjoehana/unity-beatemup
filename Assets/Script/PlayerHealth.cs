using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int _hp;
    [SerializeField] Animator _animator;
    [SerializeField] UnityEvent _ondie;
    int _currentHp;
    // Start is called before the first frame update
    void Start()
    {
        _currentHp = _hp;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Damage(int amount)
    {
        _currentHp = _currentHp - amount;
        Debug.Log(_currentHp);
            _animator.SetTrigger("Hit");
        if (_currentHp <= 0)

        {
            Debug.Log(_currentHp);
           
                _animator.SetTrigger("Death");
            _ondie.Invoke();
            }

        }
    }


