using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HamsterQuestStep2 : QuestStep
{
    void Update()
    {
        if (Manager.hasSunflower){
            FinishQuestStep();
        }
    }
}
