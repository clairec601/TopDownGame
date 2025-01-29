using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest 
{
    public QuestInfo info;
    public QuestState state;
    private int currentStepIndex;

    public Quest(QuestInfo info){ //all quests start with this
        this.info = info;
        this.state = QuestState.CAN_START; //all quests can be started at any time
        this.currentStepIndex = 0;
    }

    public Quest(QuestInfo info, QuestState state, int index){ 
        this.info = info;
        this.state = state;
        this.currentStepIndex = index;
    }

    public void NextStep(){
        currentStepIndex++;
        Debug.Log("index: " + currentStepIndex);
    }

    public bool CurrentStepExists(){
        if (currentStepIndex < info.questSteps.Length){
            return true;
        }
        return false;
    }

    public void InstantiateCurrentQuestStep(Transform parentTransform)
    {
        GameObject questStepPrefab = GetCurrentQuestStepPrefab();
        if (questStepPrefab != null)
        {
            QuestStep questStep = Object.Instantiate<GameObject>(questStepPrefab, parentTransform)
                .GetComponent<QuestStep>();
            questStep.InitializeQuestStep(info.id);  
        }
    }

    private GameObject GetCurrentQuestStepPrefab()
    {
        GameObject questStepPrefab = null;

        if (CurrentStepExists())
        {
            questStepPrefab = info.questSteps[currentStepIndex];
        }
        
        return questStepPrefab;
    }


}
