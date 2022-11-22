using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCountController : MonoBehaviour
{
    [SerializeField] private CharacterBody characterPrefab;
    [SerializeField] private List<CharacterBody> characterBodies = new List<CharacterBody>();


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
                InstantiateCharacter();
            }
        }
    }

    private void InstantiateCharacter()
    {
        CharacterBody c = Instantiate(characterPrefab, transform.position, Quaternion.identity);
        SetCharacterParentToThis(c.transform);
        SetRandomPosToCharacter(c.transform);
        characterBodies.Add(c);
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

    private void SetDecrease(int amount)
    {
        if (Mathf.Abs(amount) > characterBodies.Count)
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
        characterBodies[0].gameObject.SetActive(false);
        characterBodies.RemoveAt(0);
    }

    public void SetMultiply(float multiplyAmount)
    {
        int targetCount = (int)(characterBodies.Count * multiplyAmount);
        ChangeAmount(targetCount - characterBodies.Count);
    }
    
    
    
}
