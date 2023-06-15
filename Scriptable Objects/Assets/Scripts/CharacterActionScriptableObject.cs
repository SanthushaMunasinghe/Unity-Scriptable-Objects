using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterScriptableObjects", menuName = "ScriptableObjects/CharacterAction")]
public class CharacterActionScriptableObject : ScriptableObject
{
    public string actionType = "Default";
    public int actiopnValue = 10;
}