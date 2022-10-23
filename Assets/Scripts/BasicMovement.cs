using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;


    private void Update()
    {
        transform.position += new Vector3(inputManager.x, 0, inputManager.z) * speed*Time.deltaTime;
    }
}
