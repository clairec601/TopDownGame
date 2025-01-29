using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManateeQuestStep : QuestStep
{
    void Update()
    {
        if (Manager.manateeGameComplete == true){
            FinishQuestStep();
        }
    }
}
