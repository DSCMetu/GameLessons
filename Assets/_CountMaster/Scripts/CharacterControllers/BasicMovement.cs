using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private void Awake()
    {
        InputManager.OnInputGiven += MoveHorizontal;
    }

    public void MoveHorizontal(float delta)
    {
        transform.position += new Vector3(delta, 0, 0);
        transform.position = new Vector3(Mathf.Clamp(transform.position.x + delta, -3, 3), transform.position.y, transform.position.z);

    }

}
