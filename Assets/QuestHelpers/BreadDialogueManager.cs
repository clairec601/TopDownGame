using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Ink.Runtime;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class BreadDialogueManager : MonoBehaviour
{
    public static BreadDialogueManager instance;
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private TextAsset startInkJSON;
    private Story currentStory; //uses Ink
    public bool isPlaying { get; private set; }

        

    private void Awake(){
        instance = this;
    }

    private void Start(){
        isPlaying = false;
        dialoguePanel.SetActive(false);

        EnterDialogue(startInkJSON);
    }

    private void Update(){
        if (!isPlaying){
            return;
        }

        if (Input.GetKeyDown(KeyCode.Return)){
            canContinue();
        }
    }

    public void Bind(Story story){
        story.BindExternalFunction("finishBreadGame", () => {
            Manager.breadGameComplete = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        });

    }

    public void EnterDialogue(TextAsset inkJSON){
        currentStory = new Story(inkJSON.text); //uses Ink
        Bind(currentStory);

        isPlaying = true;
        dialoguePanel.SetActive(true);

        canContinue();

    }

    private void ExitDialogue(){
        isPlaying = false;
        dialoguePanel.SetActive(false);
        dialogueText.text = "";
    }

    private void canContinue(){
        if (currentStory.canContinue){
            dialogueText.text = currentStory.Continue();
        }
        else {
            ExitDialogue();
        }
    }

}
