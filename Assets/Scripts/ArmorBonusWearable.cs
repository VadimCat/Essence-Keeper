using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorBonusWearable : BonusWereable {
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == Tags.ENEMY)
        {

           Charger  gavno = collision.gameObject.GetComponent<Enemy>() as Charger;
        }
    }

}
