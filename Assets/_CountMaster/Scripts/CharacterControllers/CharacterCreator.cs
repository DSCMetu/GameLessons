using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CharacterCreator : MonoBehaviour
{
    [SerializeField] private CharacterBody characterPrefab;
    
    
    
    
    public CharacterBody InstantiateCharacter()
    {
        CharacterBody c = Instantiate(characterPrefab, transform.position, Quaternion.identity);
        SetCharacterParentToThis(c.transform);
        SetRandomPosToCharacter(c.transform);
        return c;
    }
    
    
    private void SetCharacterParentToThis(Transform character)
    {
        character.SetParent(transform);
    }

    private void SetRandomPosToCharacter(Transform character)
    {
        Vector3 randomPos = new Vector3(Random.Range(0f, 2f), 0, Random.Range(0f, 2f));
        character.localPosition += randomPos;
    }
    
    
}
