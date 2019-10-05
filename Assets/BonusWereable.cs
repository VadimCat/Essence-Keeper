using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BonusWereable : MonoBehaviour {

    protected int _level = 1;
    public virtual int Level
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
