using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearQuestStep : QuestStep
{

    void Update()
    {
        if (Manager.hasSock == true){
            FinishQuestStep();
        }
    }
}
