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
        Vector3 pos = transform.position;
        transform.localPosition = new Vector3(Mathf.Clamp(pos.x + delta*speed, -3, 3), pos.y, pos.z);
    }

}
