using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCountController : MonoBehaviour
{
    private CharacterCreator _creator;
    private CharacterRemover _remover;
    [SerializeField] private List<CharacterBody> characterBodies = new List<CharacterBody>();


    private void Awake()
    {
        _creator = GetComponent<CharacterCreator>();
        _remover = GetComponent<CharacterRemover>();
    }

    private void Start()
    {
        ChangeAmount(1);
    }


    public void SetMultiply(float multiplyAmount)
    {
        int targetCount = (int)(characterBodies.Count * multiplyAmount);
        ChangeAmount(targetCount - characterBodies.Count);
    }
    

    public void ChangeAmount(int amount)
    {
        if (amount < 0)
        {
            SetDecrease(amount);
        }
        else
        {
            for (int i = 0; i < amount; i++)
            {
                CharacterBody c = _creator.InstantiateCharacter();
                c.onCharacterDie += CharacterDied;
                characterBodies.Add(c);
            }
        }
    }

    private void CharacterDied(CharacterBody obj)
    {
        if (characterBodies.Contains(obj))
        {
            characterBodies.Remove(obj);
        }
    }


    private void SetDecrease(int amount)
    {
        if (Mathf.Abs(amount) >= characterBodies.Count)
        { 
            Debug.LogError("Hata Burayı kodlamamışsın");
            return;
        }
        for (int i = 0; i < Mathf.Abs(amount); i++)
        {
            RemoveCharacter();
        }
    }

    private void RemoveCharacter()
    {
        _remover.RemoveCharacter(characterBodies[0]);
        characterBodies.RemoveAt(0);
    }

   
    
    
    
}
