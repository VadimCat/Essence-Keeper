using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootsBonusWearable : BonusWereable {

    Rigidbody _rBody;
    float _bonusScale = 100f;
    
    private void Awake()
    {
        _rBody = gameObject.GetComponent<Rigidbody>();
    }
    private void LateUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        _rBody.velocity += new Vector3(x, 0, z) * Level * _bonusScale * Time.deltaTime;
    }
}