
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{
    private const string ENEMY_TAG = "Enemy";
    private EnemyIcons _enemy;

    private void Start()
    {
        _enemy = FindObjectOfType<EnemyIcons>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag(ENEMY_TAG))
        {
            Destroy(collision.gameObject);
            _enemy.DestroyImage();
        }
        Destroy(gameObject);
    }
}
 