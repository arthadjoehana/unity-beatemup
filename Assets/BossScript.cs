using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class BossScript : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float _zoneChase;
    [SerializeField] float stopchase;
    [SerializeField] GameObject target;
    float targetDistance;
    [SerializeField] Animator _myAnimator;
    [SerializeField] Transform _root;
    [SerializeField] EnemyPunch _attack;
    bool _isAttacking;
    bool _human;
    [SerializeField] Health _myhealth;
    [SerializeField] float _PhaseHealth;

    // Update is called once per frame


    private void Start()
    {
        
        _human = true;
    }
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
        // human mode
        if (_human == true)
        {
            _myAnimator.SetBool("Human", true);
        }
        else
        {
            _myAnimator.SetBool("Human", false);
        }
        // transform
        if (_myhealth.currenthp <= _PhaseHealth)
        {
            _myAnimator.SetTrigger("Transform");
            OnWolf();
        }
    }
    

    private void OnWolf()
    {
        _human = false;
        _myAnimator.SetBool("Wolf", true);
    }
    private void stopChasePlayer()
    {
        /*Do Nothing*/
        _myAnimator.SetBool("isWalking", false);

    }
    private void ChasePlayer()
    {
        if (_root.position.x < target.transform.position.x)
        {
            _root.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            _root.rotation = Quaternion.Euler(0, 180, 0);
        }

        if(_isAttacking == false)
        {
            _root.position = Vector2.MoveTowards(_root.position, target.transform.position, speed * Time.deltaTime);
            _myAnimator.SetBool("isWalking", true);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_root.position, _zoneChase);
    }


    // Je declenche l'animation d'attaque
    public void LaunchAttack()
    {
        _myAnimator.SetTrigger("isAttacking");
        _isAttacking = true;
    }


    // Je calcul les degats
    public void ApplyDamage()
    {
        _attack.ApplyDamage();
        _isAttacking = false;
    }
}