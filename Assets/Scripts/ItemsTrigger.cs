using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemsTrigger : MonoBehaviour
{
    /// <summary>
    /// 进行各种道具的碰撞检测
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter2D(Collider2D other)
    {
        // 如果本物体是加速道具，碰撞体是玩家
        if (gameObject.CompareTag("SpeedUp") && other.CompareTag("Player"))
        {
            ItemSpeedUp(other);
        }
    }

    /// <summary>
    /// 加速道具
    /// </summary>
    /// <param name="playerCollider"></param>
    private void ItemSpeedUp(Collider2D playerCollider)
    {
        PlayerController player = playerCollider.GetComponent<PlayerController>();
        player.speed += Settings.speedUpItemValue;
        Destroy(gameObject);
    }
}
