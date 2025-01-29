using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleQuestStep : QuestStep {

    // Update is called once per frame
    void Update()
    {
        if (TurtleClickScript.turtleCount == 15){
            FinishQuestStep();
        }
    }
}
