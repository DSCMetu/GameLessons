using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public float x;
    public float z;
    
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            z = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            z = -1;
        }
        else
        {
            z = 0;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x = -1;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            x = 1;
        }
        else
        {
            x = 0;
        }
    }
    
    
    
}
