using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorBonusWearable : BonusWereable
{
    Spike[] _spikes = new Spike[4];
    private void Awake()
    {
        GameObject spike = Prefs.SPIKE;
        for(int i = 0; i < 4; i++)
        {
            _spikes[i] = Instantiate(spike, transform.position + Vector3.forward , Quaternion.Euler(90,0,0), transform).
                                    GetComponent<Spike>();
            _spikes[i].gameObject.transform.RotateAround(transform.position, Vector3.up, 90 * i);
            _spikes[i].Level = Level;
            _spikes[i].Deactivate();
        }
        _spikes[0].Activate();
    }
    public override int Level
    {
        get
        {
            return _level;
        }
        set
        {
            _level = value;
            for(int i = 0; i < 4; i++)
            {
                if(i < Level)
                {
                    _spikes[i].Activate();
                }
                _spikes[i].Level = Level;
            }
        }
    }


}
