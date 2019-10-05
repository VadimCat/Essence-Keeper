using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody rigidbody;
    int lives;

    List<BonusWereable> bonuses = new List<BonusWereable>();

    public int Lives
    {
        get
        {
            return lives;
        }
        set
        {
            lives = value;
        }
    }

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        rigidbody.velocity = new Vector3(x, 0, z) * speed * Time.deltaTime;
    }

    public void GetHurt()
    {
        if (bonuses.Count > 0)
        {

        }
        else
        {
            bonuses[Random.Range(0, bonuses.Count)].Remove();
        }
    }
}
