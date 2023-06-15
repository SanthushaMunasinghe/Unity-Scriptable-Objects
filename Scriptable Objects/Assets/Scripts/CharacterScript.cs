using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterScript : MonoBehaviour
{
    [SerializeField] private CharacterScriptableObject characterScriptable;

    void Start()
    {
        GetComponent<SpriteRenderer>().color = characterScriptable.charcaterColor;
    }
}
