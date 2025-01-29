using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestEventsManager : MonoBehaviour
{
    public static QuestEventsManager instance { get; private set;}
    public QuestEvents questEvents;

    private void Awake(){
        instance = this;
        questEvents = new QuestEvents();
    }


}
