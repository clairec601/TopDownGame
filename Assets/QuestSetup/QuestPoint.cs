using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestPoint : MonoBehaviour
{
    [SerializeField] private QuestInfo questInfoForPoint;
    private string questId; 
    public static QuestState currentQuestState { get; private set; }
    //attach to each character

    private void Awake(){
        questId = questInfoForPoint.id;
    }

    private void OnEnable(){
        QuestEventsManager.instance.questEvents.onQuestStateChange += QuestStateChange;
    }

    private void OnDisable(){
        QuestEventsManager.instance.questEvents.onQuestStateChange -= QuestStateChange;
    }

    private void QuestStateChange(Quest quest){
        if (quest.info.id.Equals(questId)){
            currentQuestState = quest.state;
        }
    }
}
