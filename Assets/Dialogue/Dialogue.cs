using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{

    private bool isColliding;
    [SerializeField] private GameObject dialogueTrigger;
    [SerializeField] private TextAsset inkJSONStart; //makes it show in inspector
    [SerializeField] private TextAsset inkJSONBetween; //makes it show in inspector
    [SerializeField] private TextAsset inkJSONComplete; //makes it show in inspector
    [SerializeField] private TextAsset inkJSONAfter; //makes it show in inspector   

    public GameObject obj;

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

        if (this.gameObject.name == "Hamster"){ //dont trigger dialogue if mouse was not clicked at all
            if (isColliding && !DialogueManager.instance.isPlaying && QuestManager.instance.CheckState(obj.name).Equals(QuestState.IN_PROGRESS) && HamsterDialogueManager.hamsterWasMoved == false){
                dialogueTrigger.SetActive(false);
                isColliding = false;
            }
        }

        if (isColliding && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.isPlaying && QuestManager.instance.CheckState(obj.name).Equals(QuestState.IN_PROGRESS)){
            DialogueManager.instance.EnterDialogue(inkJSONBetween);
        }

        else if (isColliding && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.isPlaying && QuestManager.instance.CheckState(obj.name).Equals(QuestState.CAN_FINISH)){
            DialogueManager.instance.EnterDialogue(inkJSONComplete);
        }

        else if (isColliding && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.isPlaying && QuestManager.instance.CheckState(obj.name).Equals(QuestState.FINISHED)){
            DialogueManager.instance.EnterDialogue(inkJSONAfter);
        }

        else if (isColliding && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.isPlaying){
            DialogueManager.instance.EnterDialogue(inkJSONStart);
        }

    }

    
}