using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurQuestStep2 : QuestStep
{
    // Update is called once per frame
    void Update()
    {
        if (Manager.hasWater == true){
            FinishQuestStep();
        }
    }
}
