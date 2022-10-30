using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float _movementSpeed = 3f;
    [SerializeField] 
    private float _rotateSpeed = 0.5f;

    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal")*_rotateSpeed;
        var vertical = Input.GetAxis("Vertical")*_movementSpeed;
        transform.Translate(Vector3.forward*vertical*Time.deltaTime);
        transform.Rotate(0, horizontal, 0);
    }
}