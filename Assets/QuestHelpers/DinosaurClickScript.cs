using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinosaurClickScript : MonoBehaviour
{

   public static DinosaurClickScript instance { get; private set; }  
   public int count;
    
   void Awake(){
      instance = this;
   }
   private void Update(){

      if (Input.GetMouseButtonDown(0)){
         Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
         RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction); //returns raycast

         if (hit.collider != null) {
            Destroy(hit.collider.gameObject);
            count++;
         }
      }

   }
}
