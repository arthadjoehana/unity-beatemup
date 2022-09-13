using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    [SerializeField] float _hp;
    [SerializeField] UnityEvent _onDamage;
    [SerializeField] Animator _animator;


    // Start is called before the first frame update

   public float currenthp;
    private void Start()
    {
        currenthp = _hp;
    }

    public void Damage(int amount)
    {
        currenthp = currenthp - amount;
        Debug.Log(currenthp / _hp);
        if (_animator != null)
        {
            _animator.SetTrigger("Hit");
        }


        if (currenthp <= 0)
        {
            Debug.Log(currenthp);
            if (_animator != null)
            {
                _animator.SetTrigger("Death");
            }
            if (_animator == null)
            {
                Destroy(gameObject);
                {
                }
            }

        }
    }
}