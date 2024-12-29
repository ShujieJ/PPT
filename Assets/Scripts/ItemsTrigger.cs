using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemsTrigger : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (gameObject.CompareTag("SpeedUp") && other.CompareTag("Player"))
        {
            PlayerController player = other.GetComponent<PlayerController>();
            player.speed += Settings.speedUpItemValue;
            Destroy(gameObject);
        }
    }
}
