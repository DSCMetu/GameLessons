using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class RotatingObstacles : Obstacle
{
    [SerializeField] protected Vector3 rotationSpeed;
    
    private void Update()
    {
        transform.Rotate(rotationSpeed*Time.deltaTime);
    }
}
