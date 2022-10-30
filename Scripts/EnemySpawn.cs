using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    [SerializeField] public int enemyCounter = 3 ;
    void Start()
    {
        for (int i = 0; i < enemyCounter; i++)
        {
            var enemy = Instantiate(_enemy);
            enemy.transform.position = new Vector3(Random.Range(-20, 20), Random.Range(0.01f, 0.1f), Random.Range(20, -20));
        }
    }
}
