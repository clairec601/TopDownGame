using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtterQuestStep : QuestStep
{
    void Update()
    {
        if (Manager.hasStar){
            FinishQuestStep();
        }
    }
}
