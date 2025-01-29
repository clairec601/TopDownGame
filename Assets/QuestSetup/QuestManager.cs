using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{

    public static QuestManager instance { get; private set; }
    public Dictionary<string, Quest> questMap;
    public static int finishedCount = 0;
    private void Awake(){
        instance = this;
        questMap = CreateMap();
        
    }

    private void OnEnable(){ //script is ready to use (enabled)
        //attaches specific function (event handler) to an event; whenever event occurs, function is called
        QuestEventsManager.instance.questEvents.onStartQuest += StartQuest;
        QuestEventsManager.instance.questEvents.onAdvanceQuest += AdvanceQuest;
        QuestEventsManager.instance.questEvents.onFinishQuest += FinishQuest;
    }

    private void OnDisable(){
        //not listening for event anymore
        QuestEventsManager.instance.questEvents.onStartQuest -= StartQuest;
        QuestEventsManager.instance.questEvents.onAdvanceQuest -= AdvanceQuest;
        QuestEventsManager.instance.questEvents.onFinishQuest -= FinishQuest;

    }

        
    private void Start() {
        foreach (Quest quest in questMap.Values){
            if (quest.state == QuestState.IN_PROGRESS){
                quest.InstantiateCurrentQuestStep(this.transform);
            }
            QuestEventsManager.instance.questEvents.QuestStateChange(quest);
        }
    }

    public QuestState CheckState(string id){
        Quest quest = GetById(id);
        return quest.state;
    }

    public void ChangeQuestState(string id, QuestState state){
        Quest quest = GetById(id);
        quest.state = state;
        QuestEventsManager.instance.questEvents.QuestStateChange(quest);
    }

    private Dictionary<string, Quest> CreateMap(){
        //name specific
        QuestInfo[] allQuests = Resources.LoadAll<QuestInfo>("Quests");
        Dictionary<string, Quest> idMap = new Dictionary<string, Quest>();
        foreach (QuestInfo info in allQuests){
            idMap.Add(info.id, new Quest(info));
        }
        return idMap;
    }

    private Quest GetById(string id){
        Quest quest = questMap[id];
        return quest;
    }

    private void StartQuest(string id){
        Quest quest = GetById(id);
        quest.InstantiateCurrentQuestStep(this.transform);
        ChangeQuestState(quest.info.id, QuestState.IN_PROGRESS);
    }
    private void AdvanceQuest(string id){
        Quest quest = GetById(id);
        quest.NextStep();

        if (quest.CurrentStepExists()){
            quest.InstantiateCurrentQuestStep(this.transform);
        }
        else {
            ChangeQuestState(quest.info.id, QuestState.CAN_FINISH);
        }
    }
    private void FinishQuest(string id){
        Quest quest = GetById(id);
        ChangeQuestState(quest.info.id, QuestState.FINISHED);
        finishedCount++;
        Debug.Log(finishedCount);
    }

}
