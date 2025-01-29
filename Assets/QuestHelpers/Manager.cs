using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public static Manager instance;
    public static bool breadGameComplete;
    public static bool bigDinosaurGameComplete;
    public static bool manateeGameComplete;
    public static bool hasCoconut;
    public static bool hasStar;
    public static bool hasSock;
    public static bool hasSunflower;
    public static bool hasCloud;
    public static bool hasWater;
    private static QuestState[] questStates = new QuestState[11];
    private static int count;
    

    
    void Awake() {
        foreach (Quest quest in QuestManager.instance.questMap.Values){
        }
        if (count == 0){
            for (int i = 0; i < 11; i++){
                questStates[i] = QuestState.CAN_START;
            }
        }
        int index = 0;
        if (count > 0){
            foreach (Quest quest in QuestManager.instance.questMap.Values){
                QuestManager.instance.ChangeQuestState(quest.info.id, questStates[index]);
                index++;
            }
        }
    }
    
    void Start() {
        count++; //important, don't delete!
    }

    void Update(){
        int index = 0;
        if (SceneManager.GetActiveScene().name == "MainGame"){
            foreach (Quest quest in QuestManager.instance.questMap.Values){
            QuestState questState = quest.state;
            questStates[index] = questState;
            index++;
        }
        }
    }
}
