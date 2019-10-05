using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Obstacle : MonoBehaviour {

    [SerializeField] DeathType death;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            other.GetComponent<Player>().GetHurt();
        else if (other.gameObject.tag == "Enemy")
            other.GetComponent<Enemy>().EnemyRemove();
        {

        }
    }
}
