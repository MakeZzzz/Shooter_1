
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private float _bulletVelocity = 20f;
    [SerializeField] public BulletDisplay _numberOfBullets;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(_bullet, transform.position, transform.rotation);
            bullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
            if (_numberOfBullets.bullets <= 0)
            {
                return;
            }
        }
    }
}
