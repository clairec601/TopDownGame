using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleClickScript : MonoBehaviour
{
    // Update is called once per frame
   Animator turtleAnim;
   public static int turtleCount;
   public static bool startClicking;
    
   void Awake(){
      turtleAnim = this.GetComponent<Animator>();
      startClicking = false;
   }

   private void Update(){

      if (Input.GetMouseButtonDown(0) && QuestManager.instance.CheckState("Turtle").Equals(QuestState.IN_PROGRESS) && startClicking){
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction); //returns raycast

        if (hit.collider != null) {
            if (hit.collider.gameObject.tag == "Turtle"){}
                turtleAnim.SetBool("isShakingTurtle", true);
                turtleCount++;
            if (turtleCount >= 15){
                turtleAnim.SetBool("isTurtleAfterIdle", true);
                turtleAnim.SetBool("isShakingTurtle", false);
            }
        }
      }

   }
}

