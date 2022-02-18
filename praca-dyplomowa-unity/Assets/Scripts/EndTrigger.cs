﻿using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.CompleteLevel();
        Destroy(gameObject);
    }
}
