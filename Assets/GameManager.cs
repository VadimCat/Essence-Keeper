using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public enum DeathType
{
    fallOut,// сапог
    spike,//   Ловушка
    fire,//    броня огня, 
    poison,//  аура смэрти
    kill,//    Меч
    crush//    Щит
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    Vector3 SpawnPoint = new Vector3(0, 0.5f, 0);

    int[] enemyDeaths = new int[6];
    int enemiesRemainming;
    int lvl = 0;
    [SerializeField] float enemyCoeficient = 1.42f;

    Vector3 spawnPoint = new Vector3(0, 0);

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        
    }

    void SetEnemies()
    {
        enemiesRemainming = Mathf.CeilToInt(Mathf.Pow(enemyCoeficient, lvl));
    }

    void GameOver()
    {

    }
}
