using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamenQuestStep : QuestStep
{
    // Update is called once per frame
    void Update()
    {
        if (PlayerSpawn.ramenWasPlaced){
            FinishQuestStep();
        }
    }
}
