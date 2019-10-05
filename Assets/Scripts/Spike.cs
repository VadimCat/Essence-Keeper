using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour {
    int _level;
    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;
        }
    }
    [SerializeField]
    int _multiplier = 2;
    [SerializeField]
    float angularVelocity;
    Transform _parent;
    DeathType _deathType = DeathType.spike;
    private void Awake()
    {
        _parent = gameObject.transform.parent;
        GetComponent<CapsuleCollider>().isTrigger = true;

    }
    private void Update()
    {
        transform.RotateAround(_parent.position, Vector3.up, angularVelocity);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == Tags.ENEMY)
        {
            other.gameObject.GetComponent<Enemy>().GetDamage(Level * _multiplier, _deathType);
        }
    }

    public void Activate()
    {
        this.GetComponent<CapsuleCollider>().enabled = true;
        this.GetComponent<MeshRenderer>().enabled = true;
    }
    public void Deactivate()
    {
        this.GetComponent<CapsuleCollider>().enabled = false;
        this.GetComponent<MeshRenderer>().enabled = false;
    }
}
