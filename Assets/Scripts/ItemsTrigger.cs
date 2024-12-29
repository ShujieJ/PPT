using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class ItemsTrigger : MonoBehaviour
{
    /// <summary>
    /// 信号：捡起加速道具
    /// </summary>
    public UnityEvent<GameObject> onPickUpSpeedUp;

    /// <summary>
    /// 进行各种道具的碰撞检测
    /// </summary>
    /// <param name="other"></param>
    public void OnTriggerEnter2D(Collider2D other)
    {
        // 如果本物体是加速道具，碰撞体是玩家
        if (gameObject.CompareTag("SpeedUp") && other.CompareTag("Player"))
        {
            // 触发onPickUpSpeedUp事件，传递玩家角色对象
            onPickUpSpeedUp?.Invoke(other.gameObject);
            // 销毁本物体
            Destroy(gameObject);
        }
    }
}
