using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LampInteractableDialogue : MonoBehaviour
{

    private bool isColliding;
    [SerializeField] private GameObject dialogueTrigger;
    [SerializeField] private TextAsset inkJSON; //makes it show in inspector
    [SerializeField] private TextAsset dinosaurQuestInkJSON;
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

     private void OnTriggerEnter2D(Collider2D col){
        if (col.gameObject.tag == "Player"){
            dialogueTrigger.SetActive(true);
            isColliding = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col){
        if (col.gameObject.tag == "Player"){
            dialogueTrigger.SetActive(false);
            isColliding = false;
        }
    }

    void Awake(){
        dialogueTrigger.SetActive(false);
    }

    void Start() {
        DialogueManager.instance.EnterDialogue(dinosaurQuestInkJSON);
    }

    void Update(){
        if (isColliding && Input.GetKeyDown(KeyCode.Space) && !DialogueManager.instance.isPlaying){
            DialogueManager.instance.EnterDialogue(inkJSON);
        }
        
    }
}
