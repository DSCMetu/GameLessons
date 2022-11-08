using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static Action<float> OnInputGiven;
    public float x;
    public float z;
    public Vector2 inputPos;
    public float delta;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            inputPos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            Vector2 newPos = Input.mousePosition;
            delta = newPos.x - inputPos.x;
            inputPos = newPos;
            OnInputGiven.Invoke(delta*Time.deltaTime);

        }
        if (Input.GetMouseButtonUp(0))
        {

        }
    }
    
    
    
}
