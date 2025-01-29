using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurQuestStep : QuestStep
{
    void Start()
    {
        if (Manager.hasCloud == true){
            FinishQuestStep();
        }
    }
}
