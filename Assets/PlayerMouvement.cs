using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMouvement : MonoBehaviour
{
    // Start is called before the first frame update
    // Vector2 _playerMovement;

    [SerializeField] InputActionReference _MoveInput;
     [SerializeField] InputActionReference _AttackInput;

    [SerializeField] Transform _root;
    [SerializeField] float _speed;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Animator _animator;
    [SerializeField] float _MovingThreshold;
    [SerializeField] Punch _attack;


    void Start()
    {
        _AttackInput.action.started += AttackStart;
        _AttackInput.action.performed += UpdateAttack;
        _AttackInput.action.canceled += EndAttack;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 moveInput = _MoveInput.action.ReadValue<Vector2>();
        if (moveInput.x > 0)
        {
            _root.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (moveInput.x < 0)   //left
        {
            _root.rotation = Quaternion.Euler(0, 180, 0);
        }


        if (moveInput.magnitude > _MovingThreshold)  // si on est ent train de bouger alors 
        {
            _animator.SetBool("Iswalking", true);
        }
        else
        {                 //sinon c'est qu'on bouge pas donc false
            _animator.SetBool("Iswalking", false);
        }

    }

    void FixedUpdate()
    {
        Vector3 moveInput = _MoveInput.action.ReadValue<Vector2>();
        rb.MovePosition(rb.transform.position + (moveInput * _speed * Time.fixedDeltaTime));
    }
    private void AttackStart(InputAction.CallbackContext obj)
    {
       // _attack.LaunchAttack();
        _animator.SetTrigger("Attack");

    }
    private void UpdateAttack(InputAction.CallbackContext obj)
    {

    }
    private void EndAttack(InputAction.CallbackContext obj)
    {
    }
    public void LaunchAttack()
    {
        _attack.LaunchAttack();
    }
}

