using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterScriptableObjects", menuName = "ScriptableObjects/Character")]
public class CharacterScriptableObject : ScriptableObject
{
    public Color charcaterColor;
    public int health = 100;
    public CharacterActionScriptableObject characterAction;
}
