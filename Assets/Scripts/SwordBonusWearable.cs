using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBonusWearable : BonusWereable {

    GameObject sword;
    private void Awake()
    {
        sword = Instantiate(Prefs.BONUS_SWORD, transform.position + Vector3.up * 2, Quaternion.identity);
        sword.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Attack());
        }
    }
    private IEnumerator Attack()
    {
        sword.SetActive(true);
        for(int i = 0; i < 15; i++)
        {
            sword.transform.RotateAround(Vector3.left, 5);
        }
        sword.transform.RotateAround(Vector3.left, -5 * 15);
        sword.SetActive(false);
        yield return new WaitForSeconds(1f);

    }
}
