using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour
{

	
}
public static class Tags
{
    public static string PLAYER = "Player";
    public static string ENEMY = "Enemy";
    public static string FINISH = "Finish";
    public static string RESPAWN = "Respawn";
    public static string MAIN_CAMERA = "MainCamera";
    public static string GAME_CONTROLLER = "GameController";

}
public static class Prefs
{
    public static GameObject SPIKE = Resources.Load("Spike") as GameObject;
    public static GameObject BONUS_ITEM_BOOTS = Resources.Load("BonusItemBoots") as GameObject;
    public static GameObject BONUS_ITEM_ARMOR = Resources.Load("BonusItemArmor") as GameObject;


}
