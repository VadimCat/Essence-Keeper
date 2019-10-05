using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventManager : MonoBehaviour {

    public static EventManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    public Event OnLevelStart;


    public System.Action OnEnemyDie;
    
   
}
