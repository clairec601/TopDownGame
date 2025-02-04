using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class QuestStep : MonoBehaviour
{
    private bool isFinished = false;
    private string questId;
    private int stepIndex;

    public void InitializeQuestStep(string questId){ 
        this.questId = questId;
    }
    
    protected void FinishQuestStep(){
        if (!isFinished){
            isFinished = true;
            QuestEventsManager.instance.questEvents.AdvanceQuest(questId);
        }
    }
}
