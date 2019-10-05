using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItem : MonoBehaviour {


    [SerializeField] BonusWereable bonusEffect;

    [SerializeField] GameObject PlayerPrefab;

    void GiveBonus(Player pl)
    {
       // pl.gameObject.AddComponent<>
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            //other.GetComponent.
            //other.GiveBonus();
        }
    }
}
