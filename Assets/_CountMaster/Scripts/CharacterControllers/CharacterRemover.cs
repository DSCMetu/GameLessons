using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRemover : MonoBehaviour
{
    public void RemoveCharacter(CharacterBody c)
    {
        c.gameObject.SetActive(false);
    }
}
