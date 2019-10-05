using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float speed;

    Rigidbody rigidbody;
    int lives;

    List<BonusWereable> bonuses = new List<BonusWereable>();
    public List<BonusWereable> Bonuses
    {
        get
        {
            return bonuses;
        }
        set
        {
            bonuses = value;
        }
    }

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
        rigidbody.velocity = Vector3.zero/*new Vector3(x, 0, z) * speed * Time.deltaTime*/;
        rigidbody.AddForce(new Vector3(x, 0, z) * speed * Time.deltaTime, ForceMode.VelocityChange);
    }

    public void GetHurt()
    {
        if (bonuses.Count > 0)
        {
            int bonusToRemoveInd = Random.Range(0, Bonuses.Count);
            Destroy(Bonuses[bonusToRemoveInd]);
            Bonuses.RemoveAt(bonusToRemoveInd);
        }
        else
        {
            Die();
        }
    }
    private void Die()
    {
       // GameManager.gameover;
    }
}
