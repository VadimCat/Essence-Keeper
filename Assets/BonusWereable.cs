using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BonusWereable : MonoBehaviour {

    int _level = 1;
    public int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;
        }
    }


}
