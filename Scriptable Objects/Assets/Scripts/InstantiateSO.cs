using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSO : MonoBehaviour
{
    CharacterScriptableObject charaSOTest;

    private void Start()
    {
        charaSOTest = (CharacterScriptableObject)ScriptableObject.CreateInstance(typeof(CharacterScriptableObject));
        Debug.Log(charaSOTest.health);
        ScriptableObject.Destroy(charaSOTest, 4);
    }
}
