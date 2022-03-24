using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollecting : MonoBehaviour
{
    private bool collected = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Player") && collected == false)
        {
            Score.scoreValue += 1;
            Destroy(gameObject);
            collected = true;
        }
    }
}
