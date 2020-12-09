﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite checkPointOnSprite, checkPointOffSprite;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("OnTriggerEnter2D");
        if (collision.CompareTag("Player"))
        {
            CheckPointController.instance.DeactiveCheckPoint();
            spriteRenderer.sprite = checkPointOnSprite;
            CheckPointController.instance.SetSpawnPoint(transform.position);
            PlayerController.instance.currentHP = PlayerController.instance.maxHP;
        }
    }

    public void ResetCheckPoint()
    {
        spriteRenderer.sprite = checkPointOffSprite;
    }
}
