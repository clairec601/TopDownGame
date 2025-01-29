using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class BigDinosaurDialogueManager : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextAsset inkJSON;
    public bool isPlaying { get; private set; }

    private Story currentStory; //uses Ink
        
    private void Start(){
        isPlaying = false;
        dialoguePanel.SetActive(false);
    }

    private void Update(){
        
        if (DinosaurClickScript.instance.count == 8){
            EnterDialogue(inkJSON);
        }
        if (Input.GetKeyDown(KeyCode.Return)){
            CanContinue();
        }
    }

    public void Bind(Story story){

        story.BindExternalFunction("finishBigDinosaurGame", () => {
            Manager.bigDinosaurGameComplete = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
        });
    }

    public void EnterDialogue(TextAsset inkJSON){
        currentStory = new Story(inkJSON.text); //uses Ink
        isPlaying = true;
        Bind(currentStory);

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

