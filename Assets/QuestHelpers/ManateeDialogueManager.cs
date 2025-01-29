using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ManateeDialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextAsset inkJSON;
    private bool waitOnce;
    
    public bool isPlaying { get; private set; }
    private Story currentStory; //uses Ink
        

    private void Start(){
        waitOnce = false;
        isPlaying = false;
        dialoguePanel.SetActive(false);
    }

    private void Update(){
        if (RhythmGameNotes.lastWasDestroyed && !waitOnce){
            EnterDialogue(inkJSON);
            waitOnce = true;
        }

        if (!isPlaying){
            return;
        }
        if (Input.GetKeyDown(KeyCode.Return)){
            Debug.Log("pressed");
            CanContinue();
        }
    }

     public void Bind(Story story){
        story.BindExternalFunction("finishManateeGame", () => {
            Manager.manateeGameComplete = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);
        });

    }


    public void EnterDialogue(TextAsset inkJSON){
        currentStory = new Story(inkJSON.text); //uses Ink
        Bind(currentStory);
        
        isPlaying = true;
        dialoguePanel.SetActive(true);

        CanContinue();

    }

    private void ExitDialogue(){
        isPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    private void CanContinue(){
        if (currentStory.canContinue){
            dialogueText.text = currentStory.Continue();
        }
        else {
            ExitDialogue();
        }
    }


}

