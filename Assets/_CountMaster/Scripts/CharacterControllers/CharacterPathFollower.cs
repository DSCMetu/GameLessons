using System;
using System.Collections;
using System.Collections.Generic;
using PathCreation.Examples;
using UnityEngine;

public class CharacterPathFollower : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private PathFollower pathFollower;
    [SerializeField] private EventTriggerController eventTriggerController;


    private void OnEnable()
    {
        eventTriggerController.eventTrigger += StartMovement;
    }

    private void OnDisable()
    {
        eventTriggerController.eventTrigger -= StartMovement;
    }


    private void Start()
    {
        pathFollower.speed = 0;
    }




    private void StartMovement()
    {
        pathFollower.speed = speed;
    }
    
    
}
