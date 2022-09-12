using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchProxy : MonoBehaviour
{
    [SerializeField] EnemyPunch _punch;

    public void TriggerDamge()
    {
        _punch.ApplyDamage();
    }
}
