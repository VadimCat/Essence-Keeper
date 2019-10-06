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
                AddBonus<ArmorBonusWearable>(pl);
                break;
            case Bonuses.fireHelmet:
                AddBonus<FireHelmetBonusWearable>(pl);
                break;
            case Bonuses.sword:

                break;
            case Bonuses.shield:
                AddBonus<ShieldBonusWearable>(pl);
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
            bonus.Level = bonus.Level + 1;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == Tags.PLAYER)
        {
            CheckBonus(other.GetComponent<Player>());
            Destroy(gameObject);
        }
    }
}

