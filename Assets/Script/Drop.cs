using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Drop : MonoBehaviour
{
    [SerializeField] GameObject _drop;

    int _numberOfDrop;

    private void Start()
    {
        _numberOfDrop = 0;
    }

    public void dropLoot()
    {
        if (_numberOfDrop == 0)
        {
            Instantiate(_drop, transform.position, transform.rotation);
            _numberOfDrop++;
        }
    }
}