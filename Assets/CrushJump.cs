using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushJump : MonoBehaviour {

    [SerializeField] float time = 5;
    [SerializeField] float speed = 25;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine(jump());
    }
	
	IEnumerator jump()
    {
        float jumpTime = 0;
        while(jumpTime <= time)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            jumpTime += Time.deltaTime;
            yield return null;
        }
        while (jumpTime > 0)
        {
            transform.Translate( -Vector3.up * speed * Time.deltaTime);
            jumpTime -= Time.deltaTime;
            yield return null;
        }
        transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(jump());
    }
}
