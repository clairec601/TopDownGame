using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestInfo", menuName = "ScriptableObjects/QuestInfo", order = 1)]
public class QuestInfo : ScriptableObject
{

    public string displayName;
    public GameObject[] questSteps;
    [field: SerializeField] public string id { get; private set; }


    private void OnValidate(){
        #if UNITY_EDITOR //only runs in editor
            id = this.name;
            UnityEditor.EditorUtility.SetDirty(this); //makes Unity aware that this value has been changed and needs to be saved
        #endif
    }
}
