using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HotSpringInteractableDialogue : MonoBehaviour
{

    private bool isColliding;
    [SerializeField] private GameObject dialogueTrigger;
    [SerializeField] private TextAsset BeforeRamenQuestInkJSON;
    [SerializeField] private TextAsset AfterRamenQuestInkJSON;
    private void OnCollisionEnter2D(Collision2D col){
        if (col.gameObject.tag == "Player"){
            dialogueTrigger.SetActive(true);
            isColliding = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col){
        if (col.gameObject.tag == "Player"){
            dialogueTrigger.SetActive(false);
            isColliding = false;
        }
    }

    void Awake(){
        dialogueTrigger.SetActive(false);
    }

    void Update(){
        if (isColliding && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.isPlaying && QuestManager.instance.CheckState("Ramen") == QuestState.CAN_START){
            DialogueManager.instance.EnterDialogue(BeforeRamenQuestInkJSON);
        }
        else if (isColliding && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.isPlaying && QuestManager.instance.CheckState("Ramen") == QuestState.IN_PROGRESS){
            DialogueManager.instance.EnterDialogue(AfterRamenQuestInkJSON);
        }
        else if (QuestManager.instance.CheckState("Ramen") == QuestState.CAN_FINISH){
            dialogueTrigger.SetActive(false);
        }
        
    }
}
