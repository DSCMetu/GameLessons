using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterBody : MonoBehaviour
{
    private NavMeshAgent _nm;


    private void Awake()
    {
        _nm = GetComponent<NavMeshAgent>();
    }


    private void FixedUpdate()
    {
        _nm.SetDestination(transform.parent.position);
    }
}
