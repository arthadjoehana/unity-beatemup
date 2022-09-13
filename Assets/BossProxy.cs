using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossProxy : MonoBehaviour
{
    [SerializeField] BossScript _boss;

    public void ApplyDamage()
    {
        _boss.ApplyDamage();
    }
}
