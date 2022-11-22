using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterVerticalController : MonoBehaviour
{
    [SerializeField] private EventTriggerController trigger;
    [SerializeField] private float speed;
    private bool _isMoving;

    private void OnEnable()
    {
        trigger.eventTrigger += StartMoving;
    }

    private void OnDisable()
    {
        trigger.eventTrigger -= StartMoving; 
    }

    private void StartMoving()
    {
        _isMoving = true;
    }
    
    
    void Update()
    {
        if(!_isMoving) return;
        transform.position += new Vector3(0, 0, speed*Time.deltaTime);
    }
}
