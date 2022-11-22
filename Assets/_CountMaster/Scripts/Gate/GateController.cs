using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour
{
    [SerializeField] private int increaseAmount;
    [SerializeField] private float multiplyAmount;
    private void OnTriggerEnter(Collider other)
    {
        CharacterCountController c = other.GetComponent<CharacterCountController>();
        if (c)
        {
            if (increaseAmount != 0)
            {
                c.ChangeAmount(increaseAmount);
            }
            else
            {
                c.SetMultiply(multiplyAmount);
            }
            
        }
    }
}
