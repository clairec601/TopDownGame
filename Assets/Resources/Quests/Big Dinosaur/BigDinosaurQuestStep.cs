using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigDinosaurQuestStep : QuestStep
{

    void Update()
    {
        if (Manager.bigDinosaurGameComplete == true){
         FinishQuestStep();
      }
    }
}
