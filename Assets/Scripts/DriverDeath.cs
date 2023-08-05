using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverDeath : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameOverManager.instance.GameOver();
        }
    }
}
