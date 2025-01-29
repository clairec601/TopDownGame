using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigQuestStep : QuestStep
{
   void Update(){
      if (Manager.hasCoconut == true){
         FinishQuestStep();
      }
   }

}
