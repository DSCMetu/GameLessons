using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CharacterBody : MonoBehaviour
{
    private NavMeshAgent _nm;

    public Action<CharacterBody> onCharacterDie;

    private void Awake()
    {
        _nm = GetComponent<NavMeshAgent>();
    }


    private void FixedUpdate()
    {
        _nm.SetDestination(transform.parent.position);
    }


    private void OnTriggerEnter(Collider other)
    {
        IObstacle a = other.GetComponent<IObstacle>();
        if (a != null)
        {
            OnObstacleTrigger();
        }
    }

    private void OnObstacleTrigger()
    {
        onCharacterDie.Invoke(this);
        Destroy(gameObject);
    }
}
