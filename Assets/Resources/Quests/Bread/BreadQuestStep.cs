using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadQuestStep : QuestStep
{
   void Update(){
      if (Manager.breadGameComplete == true){
         FinishQuestStep();
      }
   }
   
}
