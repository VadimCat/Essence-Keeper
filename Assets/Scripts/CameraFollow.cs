using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    Player target;


    void Update()
    {
        if (GameManager.Instance.player == null)
            return;
        if (GameManager.Instance.player.gameObject != null)
        {
            Vector3 targetPos = GameManager.Instance.player.transform.position;
            targetPos.y = transform.position.y;
            transform.position = Vector3.Lerp(transform.position, targetPos, 0.9f);
        }
    }
}
