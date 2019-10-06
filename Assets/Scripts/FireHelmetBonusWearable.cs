using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireHelmetBonusWearable : BonusWereable {

    GameObject fireInstance;
    [SerializeField]
    float _timeInterval = 3f;
    private void Start()
    {
      //TODO:   fireInstance = 
     
        StartCoroutine(SpawnFireTrail());
    }
    public float TimeInterval 
    {
        get
        {
            return _timeInterval;
        }
        set
        {
            _timeInterval = value;
        }
    }
    IEnumerator SpawnFireTrail()
    {
        if (fireInstance != null)
        {
            Instantiate(fireInstance, transform.position, Quaternion.identity);
        }
        float delayTime = (TimeInterval - Level / 5);
        yield return new WaitForSeconds(delayTime > 1 ? delayTime : 1);
        StartCoroutine(SpawnFireTrail());
    }
}
