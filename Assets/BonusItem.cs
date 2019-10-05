using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BonusItem : MonoBehaviour {

    [SerializeField] Bonuses _bonusType;

    private void Start()
    {

    }
    void CheckBonus(Player pl)
    {
        switch(_bonusType)
        {
            case Bonuses.boot:
                AddBonus<BootsBonusWearable>(pl);
                break;
            case Bonuses.armor:

                break;
            case Bonuses.fireHelmet:

                break;
            case Bonuses.sword:

                break;
            case Bonuses.shield:

                break;
        }
    }
    void AddBonus<T>(Player player)
        where T : BonusWereable
    {
        T bonus = player.gameObject.GetComponent<T>();
        if(bonus == null)
        {
            player.gameObject.AddComponent<T>();
        }
        else
        {
            bonus.Level++;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            CheckBonus(other.GetComponent<Player>());
            Destroy(gameObject);
        }
    }
}

