using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldBonusWearable : BonusWereable {

    GameObject ShieldPrefab;
    Transform Shield;
    public override int Level
    {
        get
        {
            return base.Level;
        }

        set
        {
            Level = value;
            //TODO: Change shield color from level 
        }
    }
    private void Awake()
    {
       Shield = Prefs.BONUS_SHIELD.transform;
       Shield = Instantiate(Shield, transform.position, Quaternion.identity, transform) as Transform;
    }
    private void Update()
    {

        Shield.transform.Rotate(Vector3.up, 1f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == Tags.ENEMY)
        {
            if (Level > 1)
            {
                Level = Level - 1;
            }
            else
            {
                //TODO: Destroy Shield
            }
        }
    }
}
