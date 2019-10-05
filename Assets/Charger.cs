using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charger : Enemy
{
    GameObject _target;
    [SerializeField] int _chargerSpeed;
    bool _isMoving = false;
    Vector3 _movePoint;
    bool _isAttacking = false;

    private void OnEnable()
    {
        _rBody = gameObject.GetComponent<Rigidbody>();
        _target = GameManager.Instance.player.gameObject;
    }


    private void Start()
    {
    }
    private void Update()
    {
        if (!_isAttacking && (_target.transform.position - transform.position).magnitude < 5.65f)
        {

            StartCoroutine(Attack(_target));
        }
        else Move(_target.transform.position);

        if(_isMoving && !_isAttacking)
        {

            _rBody.velocity = (_movePoint - transform.position).normalized * MoveSpeed * Time.deltaTime;
            if((_movePoint - transform.position).sqrMagnitude < (5.65 * 5.65))
            {
                _isMoving = false;
                _rBody.velocity = Vector3.zero;
            }
        }
    }


    public int CharrgerSpeed
    {
        get
        {
            return _chargerSpeed;
        }
        set
        {
            _chargerSpeed = value;
        }
    }
    protected override IEnumerator Attack(GameObject target)
    {
        _isAttacking = true;
        yield return StartCoroutine(Wait(1.5f));
        Charge(target.transform.position);
        yield return StartCoroutine(Wait(3f));
        _isAttacking = false;
    }
    void Charge(Vector3 point)
    {
        _rBody.AddForce((point - gameObject.transform.position).normalized * CharrgerSpeed + Vector3.up, ForceMode.Impulse);
    }
    protected override void Move(Vector3 point)
    {
        _movePoint = point;
        _isMoving = true;
    }

    protected override IEnumerator Wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
