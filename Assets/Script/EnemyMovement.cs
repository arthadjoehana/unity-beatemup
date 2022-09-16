using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class EnemyMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float _zoneChase;
    [SerializeField] float stopchase;
    [SerializeField] GameObject target;
    float targetDistance;
    [SerializeField] Animator _myAnimator;
    [SerializeField] Transform _root;
    [SerializeField] EnemyPunch _attack;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Attack decision
        if (_attack.ContainsCharacter())
        {
            LaunchAttack();
            return;
        }

        // Walk Decision
        targetDistance = Vector2.Distance(transform.position, target.transform.position);
        if (targetDistance < _zoneChase && targetDistance > stopchase)
        {
            ChasePlayer();
        }
        else
        {
            stopChasePlayer();
        }
    }
    private void stopChasePlayer()
    {
        /*Do Nothing*/
        _myAnimator.SetBool("isWalking", false);

    }
    private void ChasePlayer()
    {
        if (transform.position.x < target.transform.position.x)
        {
            _root.rotation = Quaternion.Euler(0, 0, 0);

        }
        else
        {
            _root.rotation = Quaternion.Euler(0, 180, 0);
        }
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
        _myAnimator.SetBool("isWalking", true);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, _zoneChase);
    }


    // Je declenche l'animation d'attaque
    public void LaunchAttack()
    {
        _myAnimator.SetTrigger("isAttacking");

    }

    // Je calcul les degats
    public void ApplyDamage()
    {
        _attack.ApplyDamage();
    }
}

