using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BananaQuestStep : QuestStep
{
    void Update()
    {
        if (QuestManager.instance.CheckState("Banana").Equals(QuestState.IN_PROGRESS)){
            FinishQuestStep();
        }
    }
}
