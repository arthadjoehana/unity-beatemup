using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int _hp;
    [SerializeField] Animator _animator;
    [SerializeField] UnityEvent _ondie;
    [SerializeField] Canvas _canvas;
    [SerializeField] HealthUI _healthUI;

    int _currentHp;
    
    void Start()
    {
        _currentHp = _hp;
        _healthUI.SetInitialHealth(_hp);
    }

    void Update()
    {

    }
    public void Damage(int amount)
    {
        _currentHp = _currentHp - amount;
        _healthUI.UpdateHealth(_currentHp);
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


