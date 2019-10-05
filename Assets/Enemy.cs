using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{

    [SerializeField] int _health;
    public int Health
    {
        get
        {
            return _health;
        }
        set
        {
            _health = value;
        }
    }
    [SerializeField] int _attackPower;
    public int AttackPower
    {
        get
        {
            return _attackPower;
        }
        set
        {
            _attackPower = value;
        }
    }
    [SerializeField] int _moveSpeed;
    public int MoveSpeed
    {
        get
        {
            return _moveSpeed;
        }
        set
        {
            _moveSpeed = value;
        }
    }

    protected Rigidbody _rBody;
   

    protected abstract void Move(Vector3 point);
    protected abstract IEnumerator Attack(GameObject target);
    protected abstract IEnumerator Wait(float seconds);
    protected void Die()
    {
        EventManager.Instance.OnEnemyDie();
        Destroy(gameObject);
    }

}


