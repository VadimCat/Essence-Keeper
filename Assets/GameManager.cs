﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum DeathType
{
    fallOut,// сапог
    spike,//   Ловушка
    fire,//    броня огня, 
    kill,//    Меч
    crush//    Щит
}
[System.Serializable]
public enum Bonuses
{
    boot, armor, fireHelmet, sword, shield
}
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    Vector3 SpawnPoint = new Vector3(0, 0.5f, 0);

    Vector3 spawnPoint = new Vector3(0, 0);
    int[] enemyDeaths = new int[6];
    int enemiesRemainming;
    int lvl = 0;

    [SerializeField] float enemyCoeficient = 1.42f;
    [SerializeField] GameObject playerPref;
    [SerializeField] GameObject[] enemiesPrefs;

    public Player player;

    private void Awake()
    {   
        Instance = this;
    }

    private void Start()
    {
        lvl = 0;
        SetLevel(lvl);
    }

    void SetEnemies()
    {
        enemiesRemainming = Mathf.CeilToInt(Mathf.Pow(enemyCoeficient, lvl));
        player = Instantiate(playerPref, SpawnPoint, Quaternion.identity).GetComponent<Player>();
        Instantiate(enemiesPrefs[0], SpawnPoint + Vector3.left * 3 + Vector3.forward * 3, Quaternion.identity);
    }

    void SetLevel(int lvl)
    {
        SetEnemies();
    }

    void EndLevel()
    {

    }

    void GameOver()
    {

    }


}